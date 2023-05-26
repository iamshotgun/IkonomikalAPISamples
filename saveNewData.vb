'AUTHOR: BOTVINNIK ADAMAS ROLLUQUI
'SUBJECT: ADDING NEW DEPARTMENTS DATA TO iKonomikal Cloud Accounting
'LICENSE: MIT https://opensource.org/licenses/MIT
'PLEASE COLLAPSE TO THE REGIONS AND PROCEDURES
Public Class saveNewData
#Region "CLASSES FOR EVERY TIME YOU WANT TO ADD NEW"
    Public Class departmentProfileData
        Public Property modInf As programModInfo
        Public Property f001 As System.String 'DepCode: DEPARTMENT CODE
        Public Property f002 As System.String 'DepDesc: DEPARTMENT DESCRIPTION
        Public Property f003 As System.String 'OthDesc: OTHER DESCRIPTION
        Public Property f004 As System.Int32  'ExpTyp: EXPENSE TYPE
        Public Property repSort As System.Int32 'REPORT SORT

        Public Property l001 As System.String 'LABEL FOR DepCode
        Public Property l002 As System.String 'LABEL FOR DepDesc
        Public Property l003 As System.String 'LABEL FOR OthDesc
        Public Property l004 As System.String 'LABEL FOR ExpTyp
        Public Property l_repSort As System.String 'LABEL FOR REPORT SORT

        Public Property isRead As System.Int32
        Public Property rowId As System.Int64
        Public Sub New()
            reset()
        End Sub
        Public Sub New(ByVal _vf001 As System.String,
                       ByVal _vf002 As System.String,
                       ByVal _vf003 As System.String,
                       ByVal _vf004 As System.Int32,
                       ByVal _vrepSort As System.Int32,
                       ByVal _vl001 As System.String,
                       ByVal _vl002 As System.String,
                       ByVal _vl003 As System.String,
                       ByVal _vl004 As System.String,
                       ByVal _vl_repSort As System.String)
            reset()
            _f001 = _vf001
            _f002 = _vf002
            _f003 = _vf003
            _f004 = _vf004
            _repSort = _vrepSort
            _l001 = _vl001
            _l002 = _vl002
            _l003 = _vl003
            _l004 = _vl004
            _l_repSort = _vl_repSort
        End Sub
        Public Sub reset()
            _modInf = New programModInfo
            _f001 = ""
            _f002 = ""
            _f003 = ""
            _f004 = 0
            _repSort = 0
            _l001 = ""
            _l002 = ""
            _l003 = ""
            _l004 = ""
            _l_repSort = ""
            _isRead = -1
            _rowId = 1
        End Sub
    End Class
    Public Class saveRequest
        Inherits sessionToken
        Public Property prgInf As programInfo
        Public Property saveData As departmentProfileData
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
                       ByVal _vsaveData As departmentProfileData,
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
            _saveData = New departmentProfileData
            _cmdStat = recordCommandTypes.setNew
        End Sub
    End Class
#End Region
#Region "THE PROCEDURES FOR EVERYTIME YOU WANT TO ADD NEW"
    'THIS IS JUST TO INITIALIZE THE FORM (DONT MIND THIS)
    Private Sub saveProcessToken_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        expTypFld.SelectedIndex = 0
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
    'THIS PROCEDURE LETS YOU CREATE AN 'ADD' PROCESS TOKEN TO SAVE NEW MASTERFILES AND TRANSACTIONS
    'YOU HAVE TO CALL THIS PROCEDURE EVERYTIME YOU SAVE A NEW MASTEFILE
    'MAKE SURE THAT THE RESPONSE DATA CONTAINS THE 'rspChr' PROPERTY WITH VALUE OF ZERO (0) OR 'rspChr':0
    'A rspChr of ZERO (0) IS AN AFFIRMATIVE RESPONSE
    'FOR A LIST OF ALL NUMBERED MESSAGES PLEASE LOOK FOR THE NumberedSystemMessages.xlsx FILE
    Private Async Sub Step2Btn_Click(sender As Object, e As EventArgs) Handles Step2Btn.Click
        Try
            Step2ReqFld.Text = ""
            Step2RspFld.Text = ""
            Dim prgInfo As New programInfo("SS", "SS07", "")
            Dim procToken As New processToken(processTokenTypes.IsAdd,
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
    'THIS PROCEDURE EXECUTES THE ACTUAL ADDITION OF NEW DATA AND CONSUMES THE 'ADD' TOKEN
    'FLOW: LOGIN (ONLY IF YOU HAVE BEEN INACTIVE FOR 8 HOURS) -> GET 'ADD' PROCESS TOKEN -> USE ADD TOKEN AND SAVE THE DEPARTMENT DATA -> RESPONSE DATA
    'MAKE SURE THAT THE RESPONSE DATA CONTAINS THE 'rspChr' PROPERTY WITH VALUE OF ZERO (0) OR 'rspChr':0
    'A rspChr of ZERO (0) IS AN AFFIRMATIVE RESPONSE
    'FOR A LIST OF ALL NUMBERED MESSAGES PLEASE LOOK FOR THE NumberedSystemMessages.xlsx FILE
    Private Async Sub Step3Btn_Click(sender As Object, e As EventArgs) Handles Step3Btn.Click
        Try
            Step3ReqFld.Text = ""
            Step3RspFld.Text = ""
            Dim repSort As System.Int32 = 0
            If System.Int32.TryParse(repSortFld.Text, repSort) = False Then
                Throw New Exception(System.String.Format("'{0}' must be a valid System.Int32!", repSortLbl.Text))
            End If
            Dim prgInfo As New programInfo("SS", "SS07", "")
            Dim departmentData As New departmentProfileData(depCodeFld.Text,
                                                            depDescFld.Text,
                                                            othDescFld.Text,
                                                            expTypFld.SelectedIndex,
                                                            repSort,
                                                            depCodeLbl.Text,
                                                            depDescLbl.Text,
                                                            othDescLbl.Text,
                                                            expTypLbl.Text,
                                                            repSortLbl.Text)
            Dim reqToSave As New saveRequest(subsIDFld.Text,
                                            intGIDFld.Text,
                                            emailIDFld.Text,
                                            sessIDFld.Text,
                                            -180,
                                            prgInfo,
                                            departmentData,
                                            recordCommandTypes.setNew)


            Dim request = System.Net.WebRequest.CreateHttp(ikonomikalAddFld.Text & "/bcss_wbcl_wa_ss/api/ss_02_ss07_sav")
            With request
                .ContentType = "application/json"
                .Method = "POST"
            End With
            Step3ReqFld.Text = Await Task.Factory.StartNew(Function() Newtonsoft.Json.JsonConvert.SerializeObject(reqToSave))
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
            'With (Await Task.Factory.StartNew(Function() Newtonsoft.Json.JsonConvert.DeserializeObject(Of processTokenResponse)(Step3RspFld.Text)))
            'End With
            requestData = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class