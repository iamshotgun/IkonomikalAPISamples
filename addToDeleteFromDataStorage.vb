'AUTHOR: BOTVINNIK ADAMAS ROLLUQUI
'SUBJECT: UPLOADING TO B.I. DATA STORAGE TO iKonomikal Cloud Accounting
'LICENSE: MIT https://opensource.org/licenses/MIT
'PLEASE COLLAPSE TO THE REGIONS AND PROCEDURES
Public Class addToDeleteFromDataStorage
#Region "CLASSES FOR EVERY TIME YOU WANT TO UPLOAD TO B.I. B.I. STORAGE UPLOADER"
    Public Class uploadRequest
        Public Class dataRow 'THE ROWS OF THE B.I DATA STORAGE
            Public Property operation As System.String 'INSERT/DELETE OPERATION (Ex. "INSERT" or "DELETE")
            Public Property hdrID As System.Int64 'HEADER OPERATION SEQUENCE IN INT64 OR LONG NUMBER (ONLY USED FOR DELETE, KEEP THIS ZERO(0) WHEN OPERATION IS 'INSERT')
            Public Property detID As System.Int64 'PER ROW OPERATION SEQUENCE IN INT64 OR LONG NUMBER (ONLY USED FOR DELETE, KEEP THIS ZERO(0) WHEN OPERATION IS 'INSERT')
            Public Property fields As List(Of System.Object)
            Public Sub New()
                reset()
            End Sub
            Public Sub New(ByVal _voperation As System.String,
                           ByVal _vhdrID As System.Int64,
                           ByVal _vdetID As System.Int64,
                           ByVal _vfields As List(Of System.Object))
                _operation = _voperation
                _hdrID = _vhdrID
                _detID = _vdetID
                _fields = _vfields
            End Sub
            Public Sub reset()
                _operation = ""
                _hdrID = 0
                _detID = 0
                _fields = New List(Of System.Object)
            End Sub
        End Class
        Public Class dataTable 'THE B.I. DATA STORAGE CLASS
            Public Property datStrID As System.String 'THE B.I. DATA STORAGE ID
            Public Property rows As List(Of dataRow) 'THE ROWS TO INSERT/DELETE FROM THE B.I. DATA STORAGE ID
            Public Sub New()
                reset()
            End Sub
            Public Sub New(ByVal _vdatStrID As System.String,
                           ByVal _vrows As List(Of dataRow))
                reset()
                _datStrID = _vdatStrID
                _rows = _vrows
            End Sub
            Public Sub reset()
                _datStrID = ""
                _rows = New List(Of dataRow)
            End Sub
        End Class

        Public Property datStrList As List(Of dataTable) 'THE B.I. DATA STORAGE TO UPLOAD TO
        Public Sub New()
            reset()
        End Sub
        Public Sub New(ByVal _vdatStrList As List(Of dataTable))
            reset()
            _datStrList = _vdatStrList
        End Sub
        Public Sub reset()
            _datStrList = New List(Of dataTable)
        End Sub
    End Class
    Public Class uploadResponse 'THE RESPONSE AFTER UPLOADING
        Public Property insHdrID As System.Int64 'HEADER OPERATION SEQUENCE IN INT64 OR LONG NUMBER (VALUE IS > 0, WHEN THERE'S A INSERT OPERATION)
        Public Property delHdrID As System.Int64 'DELETE OPERATION SEQUENCE IN INT64 OR LONG NUMBER (VALUE IS > 0, WHEN THERE'S A DELETE OPERATION)
        Public Property modInf As programModInfo 'SYSTEM USER/GROUP AND DATE TIME INFORMATION
        Public Property rspPrc As processTokenResponse 'THE RESPONSE INFORMATION (rspID IS ZERO(0) IF THE UPLOAD IS SUCCESSFUL)
        Public Sub New()
            reset()
        End Sub
        Public Sub New(ByVal _vinsHdrID As System.Int64,
                       ByVal _vdelHdrID As System.Int64)
            reset()
            _insHdrID = _vinsHdrID
            _delHdrID = _vdelHdrID
        End Sub
        Public Sub reset()
            _insHdrID = 0
            _delHdrID = 0
            _modInf = New programModInfo
            _rspPrc = New processTokenResponse
        End Sub
    End Class
    Public Class saveRequest
        Inherits sessionToken
        Public Property prgInf As programInfo
        Public Property saveData As uploadRequest
        Public Property cmdStat As recordCommandTypes
        Public Sub New()
            reset()
        End Sub
        Public Sub New(ByVal _vsubsID As System.String,
                       ByVal _vintGID As System.String,
                       ByVal _vuserID As System.String,
                       ByVal _vsessID As System.String,
                       ByVal _vtimeOffSet As System.Int32,
                       ByVal _vprgInf As programInfo,
                       ByVal _vsaveData As uploadRequest,
                       ByVal _vcmdStat As recordCommandTypes)
            reset()
            MyBase.subsID = _vsubsID
            MyBase.intGID = _vintGID
            MyBase.userID = _vuserID
            MyBase.sessID = _vsessID
            MyBase.timeOffSet = _vtimeOffSet
            _prgInf = _vprgInf
            _saveData = _vsaveData
            _cmdStat = _vcmdStat
        End Sub
        Public Shadows Sub reset()
            MyBase.reset()
            _prgInf = New programInfo
            _saveData = New uploadRequest
            _cmdStat = recordCommandTypes.setNew
        End Sub
    End Class
#End Region
#Region "THE PROCEDURES FOR EVERYTIME YOU WANT TO UPLOAD TO B.I. STORAGE UPLOADER"
    'THIS IS JUST TO INITIALIZE THE FORM (DONT MIND THIS)
    Private Sub saveProcessToken_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    '1ST PROCEDURE
    'THIS PROCEDURE LETS YOU LOGIN AND GET A SESSION TOKEN
    'YOU LOGIN ONLY ONCE, UNLESS YOU HAVE BEEN INACTIVE FOR 8 HOURS
    'MAKE SURE THAT THE RESPONSE DATA CONTAINS THE 'rspChr' PROPERTY WITH VALUE OF ZERO (0) OR 'rspChr':0
    'A rspChr of ZERO (0) IS AN AFFIRMATIVE RESPONSE
    'FOR A LIST OF ALL NUMBERED MESSAGES PLEASE LOOK FOR THE NumberedSystemMessages.xlsx FILE
    Private Async Sub Step1Btn_Click(sender As Object, e As EventArgs) Handles Step1Btn.Click
        Try
            Step1ReqFld.Text = ""
            Step1RspFld.Text = ""
            Dim logReq As New loginRequest(emailIDFld.Text, emailPasswordFld.Text, "", "", -180)
            Dim request = System.Net.WebRequest.CreateHttp(ikonomikalAddFld.Text & "/bcss_wbcl_wa_sc/api/O1_getSCSessWBLogVer")
            With request
                .ContentType = "application/json"
                .Method = "POST"
            End With
            Step1ReqFld.Text = Await Task.Factory.StartNew(Function() Newtonsoft.Json.JsonConvert.SerializeObject(logReq))
            Dim requestData = System.Text.Encoding.UTF8.GetBytes(Step1ReqFld.Text)
            With (Await request.GetRequestStreamAsync)
                Await .WriteAsync(requestData, 0, requestData.Length)
                .Close()
            End With
            Dim response = Await request.GetResponseAsync
            Dim responseData As System.Byte() = Nothing
            Dim memStrm As New System.IO.MemoryStream
            Dim stopLoop As System.Boolean = False
            Dim readPosition As System.Int32 = 0
            With response.GetResponseStream
                Do Until stopLoop = True
                    ReDim responseData(4096)
                    readPosition = Await .ReadAsync(responseData, 0, responseData.Count)
                    If readPosition > 0 Then
                        Await memStrm.WriteAsync(responseData, 0, readPosition)
                    Else
                        stopLoop = True
                    End If
                Loop
                .Close()
            End With
            responseData = memStrm.ToArray
            response.Close()
            response = Nothing
            request = Nothing
            Step1RspFld.Text = System.Text.Encoding.UTF8.GetString(responseData)
            With (Await Task.Factory.StartNew(Function() Newtonsoft.Json.JsonConvert.DeserializeObject(Of loginResponse)(Step1RspFld.Text)))
                sessIDFld.Text = .sessID
                intGIDFld.Text = .intGID
            End With
            requestData = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '2ND PROCEDURE
    'THIS PROCEDURE LETS YOU CREATE A 'PROGRAM QUEUE' PROCESS TOKEN TO UPLOAD/DELETE ROWS FROM B.I. DATA STORAGE
    'YOU HAVE TO CALL THIS PROCEDURE EVERYTIME YOU UPLOAD/DELETE TO THE B.I. DATA STORAGE
    'MAKE SURE THAT THE RESPONSE DATA CONTAINS THE 'rspChr' PROPERTY WITH VALUE OF ZERO (0) OR 'rspChr':0
    'A rspChr of ZERO (0) IS AN AFFIRMATIVE RESPONSE
    'FOR A LIST OF ALL NUMBERED MESSAGES PLEASE LOOK FOR THE NumberedSystemMessages.xlsx FILE
    Private Async Sub Step2Btn_Click(sender As Object, e As EventArgs) Handles Step2Btn.Click
        Try
            Step2ReqFld.Text = ""
            Step2RspFld.Text = ""
            Dim prgInfo As New programInfo("BI", "BI20001", "")
            Dim procToken As New processToken(processTokenTypes.IsPrgQue,
                                              prgInfo)
            Dim reqProcToken As New processTokenRequest(subsIDFld.Text,
                                                           intGIDFld.Text,
                                                           emailIDFld.Text,
                                                           sessIDFld.Text,
                                                           -180,
                                                           procToken)

            Dim request = System.Net.WebRequest.CreateHttp(ikonomikalAddFld.Text & "/bcss_wbcl_wa_sc/api/O1_getSCPrgPrcCheckTkn")
            With request
                .ContentType = "application/json"
                .Method = "POST"
            End With
            Step2ReqFld.Text = Await Task.Factory.StartNew(Function() Newtonsoft.Json.JsonConvert.SerializeObject(reqProcToken))
            Dim requestData = System.Text.Encoding.UTF8.GetBytes(Step2ReqFld.Text)
            With (Await request.GetRequestStreamAsync)
                Await .WriteAsync(requestData, 0, requestData.Length)
                .Close()
            End With
            Dim response = Await request.GetResponseAsync
            Dim responseData As System.Byte() = Nothing
            Dim memStrm As New System.IO.MemoryStream
            Dim stopLoop As System.Boolean = False
            Dim readPosition As System.Int32 = 0
            With response.GetResponseStream
                Do Until stopLoop = True
                    ReDim responseData(4096)
                    readPosition = Await .ReadAsync(responseData, 0, responseData.Count)
                    If readPosition > 0 Then
                        Await memStrm.WriteAsync(responseData, 0, readPosition)
                    Else
                        stopLoop = True
                    End If
                Loop
                .Close()
            End With
            responseData = memStrm.ToArray
            response.Close()
            response = Nothing
            request = Nothing
            Step2RspFld.Text = System.Text.Encoding.UTF8.GetString(responseData)
            'With (Await Task.Factory.StartNew(Function() Newtonsoft.Json.JsonConvert.DeserializeObject(Of processTokenResponse)(Step2RspFld.Text)))
            'End With
            requestData = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '3RD PROCEDURE
    'THIS PROCEDURE EXECUTES THE ACTUAL UPLOAD AND CONSUMES THE 'PROGRAM QUEUE' TOKEN
    'FLOW: LOGIN (ONLY IF YOU HAVE BEEN INACTIVE FOR 8 HOURS) -> GET 'PROGRAM QUEUE' PROCESS TOKEN -> USE PROGRAM QUEUE TOKEN AND UPLOAD THE JSON DATA -> RESPONSE DATA
    'MAKE SURE THAT THE RESPONSE DATA CONTAINS THE 'rspChr' PROPERTY WITH VALUE OF ZERO (0) OR 'rspChr':0
    'A rspChr of ZERO (0) IS AN AFFIRMATIVE RESPONSE
    'FOR A LIST OF ALL NUMBERED MESSAGES PLEASE LOOK FOR THE NumberedSystemMessages.xlsx FILE
    Private Async Sub Step3Btn_Click(sender As Object, e As EventArgs) Handles Step3Btn.Click
        Try
            Step3ReqFld.Text = ""
            Step3RspFld.Text = ""
            Dim prgInfo As New programInfo("BI", "BI20001", "")
            Dim uploadData = Newtonsoft.Json.JsonConvert.DeserializeObject(Of uploadRequest)((storageListJSONFld.Text))
            Dim reqToUpload As New saveRequest(subsIDFld.Text,
                                            intGIDFld.Text,
                                            emailIDFld.Text,
                                            sessIDFld.Text,
                                            -180,
                                            prgInfo,
                                            uploadData,
                                            recordCommandTypes.setNew)


            Dim request = System.Net.WebRequest.CreateHttp(ikonomikalAddFld.Text & "/bcss_wbcl_wa_bi/api/O1_setBIDatStrDatUpl")
            With request
                .ContentType = "application/json"
                .Method = "POST"
            End With
            Step3ReqFld.Text = Await Task.Factory.StartNew(Function() Newtonsoft.Json.JsonConvert.SerializeObject(reqToUpload))
            Dim requestData = System.Text.Encoding.UTF8.GetBytes(Step3ReqFld.Text)
            With (Await request.GetRequestStreamAsync)
                Await .WriteAsync(requestData, 0, requestData.Length)
                .Close()
            End With
            Dim response = Await request.GetResponseAsync
            Dim responseData As System.Byte() = Nothing
            Dim memStrm As New System.IO.MemoryStream
            Dim stopLoop As System.Boolean = False
            Dim readPosition As System.Int32 = 0
            With response.GetResponseStream
                Do Until stopLoop = True
                    ReDim responseData(4096)
                    readPosition = Await .ReadAsync(responseData, 0, responseData.Count)
                    If readPosition > 0 Then
                        Await memStrm.WriteAsync(responseData, 0, readPosition)
                    Else
                        stopLoop = True
                    End If
                Loop
                .Close()
            End With
            responseData = memStrm.ToArray
            response.Close()
            response = Nothing
            request = Nothing
            Step3RspFld.Text = System.Text.Encoding.UTF8.GetString(responseData)
            'With (Await Task.Factory.StartNew(Function() Newtonsoft.Json.JsonConvert.DeserializeObject(Of processTokenResponse)(Step2RspFld.Text)))
            'End With
            requestData = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class