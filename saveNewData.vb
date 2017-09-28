'AUTHOR: BOTVINNIK ADAMAS ROLLUQUI
'SUBJECT: ADDING NEW DEPARTMENTS DATA TO iKonomikal Cloud Accounting
'LICENSE: MIT https://opensource.org/licenses/MIT
'PLEASE COLLAPSE TO THE REGIONS AND PROCEDURES
Public Class saveNewData
#Region "CLASSES FOR EVERY TIME YOU WANT TO ADD NEW"
    Public Enum processTokenTypes As System.Int32
        IsSave = 0
        IsAdd = 1
        IsDelete = 2
        IsData = 3
        IsClose = 4
        IsPost = 5
        IsDrop = 6
        IsSetToPost = 7
        IsSetToRev = 8
        IsAccEntGEN = 9
        IsAccEntIES = 10
        IsAccEntGRE = 11
        IsFileAttach = 12
        IsDocNotes = 13
        IsPrint = 14
        IsBIDataSource = 15
        IsBIChart = 16
        IsBIDashBoard = 17
        IsBIMSExcel = 18
        IsBIMSWord = 19
        IsBIScheduled = 20
        IsPrgQue = 21
        IsForApproval = 22
        IsImport = 23
        IsDayEnd = 24
        IsSetToDayEnd = 25
        IsSetToDERev = 26
    End Enum
    Public Enum portalTypes As System.Int32
        IsBackOffice = 0
        IsPrivate = 1
        IsPublic = 2
    End Enum
    Public Enum recordCommandTypes As System.Int32
        setNew = 0
        setSave = 1
        setRead = 2
        setDisableAll = 3
    End Enum
    Public Class sessionToken
        Public Property portalID As System.String
        Public Property portID As System.Int32
        Public Property subsID As System.String
        Public Property intGID As System.String
        Public Property userID As System.String
        Public Property sessID As System.String
        Public Property timeOffSet As System.Int32
        Public Sub New()
            reset()
        End Sub
        Public Sub New(ByVal _vportalID As System.String,
                       ByVal _vportID As System.Int32,
                       ByVal _vsubsID As System.String,
                       ByVal _vintGID As System.String,
                       ByVal _vuserID As System.String,
                       ByVal _vsessID As System.String,
                       ByVal _vtimeOffSet As System.Int32)
            reset()
            _portalID = _vportalID
            _portID = _vportID
            _subsID = _vsubsID
            _intGID = _vintGID
            _userID = _vuserID
            _sessID = _vsessID
            _timeOffSet = _vtimeOffSet
        End Sub
        Public Sub reset()
            _portalID = ""
            _portID = portalTypes.IsBackOffice
            _subsID = ""
            _intGID = ""
            _userID = ""
            _sessID = ""
            _timeOffSet = 0
        End Sub
    End Class
    Public Class processToken
        Public Property procID As processTokenTypes
        Public Property prgInf As programInfo
        Public Sub New()
            reset()
        End Sub
        Public Sub New(ByVal _vprocID As processTokenTypes,
                       ByVal _vprgInf As programInfo)
            reset()
            _procID = _vprocID
            _prgInf = _vprgInf
        End Sub
        Public Sub reset()
            _procID = processTokenTypes.IsData
            _prgInf = New programInfo
        End Sub
    End Class
    Public Class processTokenPairs
        Public Property pid As System.String
        Public Property pValue As System.Object
        Public Property plbl As System.String
        Public Sub New()
            reset()
        End Sub
        Public Sub New(ByVal _vpid As System.String,
                       ByVal _vpValue As System.Object,
                       ByVal _vplbl As System.String)
            reset()
            _pid = _vpid
            _pValue = _vpValue
            _plbl = _vplbl
        End Sub
        Public Sub reset()
            _pid = ""
            _pValue = Nothing
            _plbl = ""
        End Sub
    End Class

    Public Class programInfo
        Public Property pMODL As System.String
        Public Property pPRGM As System.String
        Public Property pPRGDSC As System.String
        Public Sub New()
            reset()
        End Sub
        Public Sub New(ByVal _vpMODL As System.String,
                       ByVal _vpPRGM As System.String,
                       ByVal _vpPRGDSC As System.String)
            reset()
            _pMODL = _vpMODL
            _pPRGM = _vpPRGM
            _pPRGDSC = _vpPRGDSC
        End Sub
        Public Sub reset()
            _pMODL = ""
            _pPRGM = ""
            _pPRGDSC = ""
        End Sub
    End Class
    Public Class programModInfo
        Public Property mUser As System.String
        Public Property mGroup As System.String
        Public Property mDate As System.Int32
        Public Property mTime As System.Int32
        Public Sub New()
            reset()
        End Sub
        Public Sub New(ByVal _vmUser As System.String,
                       ByVal _vmGroup As System.String,
                       ByVal _vmDate As System.Int32,
                       ByVal _vmTime As System.Int32)
            reset()
            _mUser = _vmUser
            _mGroup = _vmGroup
            _mDate = _vmDate
            _mTime = _vmTime
        End Sub
        Public Sub reset()
            _mUser = ""
            _mGroup = ""
            _mDate = 0
            _mTime = 0
        End Sub
    End Class

    Public Class loginRequest
        Public Property userID As System.String
        Public Property userPW As System.String
        Public Property userCap As System.String
        Public Property sessCap As System.String
        Public Property timeOffSet As System.Int32
        Public Sub New()
            reset()
        End Sub
        Public Sub New(ByVal _vuserID As System.String,
                       ByVal _vuserPW As System.String,
                        ByVal _vuserCap As System.String,
                        ByVal _vsessCap As System.String,
                        ByVal _vtimeOffSet As System.Int32)
            reset()
            _userID = _vuserID
            _userPW = _vuserPW
            _userCap = _vuserCap
            _sessCap = _vsessCap
            _timeOffSet = _vtimeOffSet
        End Sub
        Public Sub reset()
            _userID = ""
            _userPW = ""
            _userCap = ""
            _sessCap = ""
            _timeOffSet = 0
        End Sub
    End Class
    Public Class loginResponse
        Public Property subsID As System.String
        Public Property intGID As System.String
        Public Property userID As System.String
        Public Property sessID As System.String
        Public Property userName As System.String
        Public Property dteFmt As System.Int32
        Public Property dteSpFmt As System.Int32
        Public Property serverTimeOffSet As System.Int32
        Public Property clientTimeZone As System.Int32
        Public Property rspPrc As processTokenResponse
        Public Sub New()
            reset()
        End Sub
        Public Sub New(ByVal _vsubsID As System.String,
                       ByVal _vintGID As System.String,
                       ByVal _vuserID As System.String,
                      ByVal _vsessID As System.String,
                      ByVal _vuserName As System.String,
                       ByVal _vdteFmt As System.Int32,
                       ByVal _vdteSpFmt As System.Int32,
                      ByVal _vserverTimeOffSet As System.Int32,
                      ByVal _vclientTimeZone As System.Int32)
            reset()
            _subsID = _vsubsID
            _intGID = _vintGID
            _userID = _vuserID
            _sessID = _vsessID
            _dteFmt = _vdteFmt
            _dteSpFmt = _vdteSpFmt
            _userName = _vuserName
            _serverTimeOffSet = _vserverTimeOffSet
            _clientTimeZone = _vclientTimeZone
        End Sub
        Public Sub reset()
            _subsID = ""
            _intGID = ""
            _userID = ""
            _sessID = ""
            _dteFmt = 1
            _dteSpFmt = 1
            _serverTimeOffSet = 0
            _clientTimeZone = 0
            _rspPrc = New processTokenResponse
        End Sub
    End Class
    Public Class processTokenRequest
        Inherits sessionToken
        Public Property pgProcTkn As processToken
        Public Sub New()
            reset()
        End Sub
        Public Sub New(ByVal _vsubsID As System.String,
                       ByVal _vintGID As System.String,
                       ByVal _vuserID As System.String,
                       ByVal _vsessID As System.String,
                       ByVal _vtimeOffSet As System.Int32,
                       ByVal _vpgProcTkn As processToken)
            reset()
            MyBase.subsID = _vsubsID
            MyBase.intGID = _vintGID
            MyBase.userID = _vuserID
            MyBase.sessID = _vsessID
            MyBase.timeOffSet = _vtimeOffSet
            _pgProcTkn = _vpgProcTkn
        End Sub
        Public Shadows Sub reset()
            MyBase.reset()
            _pgProcTkn = New processToken
        End Sub
    End Class
    Public Class processTokenResponse
        Public Property rspID As System.Int32
        Public Property rspMsg As System.String
        Public Property rspChr As List(Of processTokenPairs)
        Public Sub New()
            reset()
        End Sub
        Public Sub New(ByVal _vrspID As System.Int32,
                       ByVal _vrspMsg As System.String,
                       ByVal _vrspChr As List(Of processTokenPairs))
            reset()
            _rspID = _vrspID
            _rspMsg = _vrspMsg
            _rspChr = _vrspChr
        End Sub
        Public Sub reset()
            _rspID = 0
            _rspMsg = ""
            _rspChr = New List(Of processTokenPairs)
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
#Region "CLASS FOR THE DEPARTMENT DATA"
    Public Class departmentProfileData
        Public Property modInf As programModInfo
        Public Property f001 As System.String 'DepCode: DEPARTMENT CODE
        Public Property f002 As System.String 'DepDesc: DEPARTMENT DESCRIPTION
        Public Property f003 As System.String 'OthDesc: OTHER DESCRIPTION
        Public Property f004 As System.Int32  'ExpTyp: EXPENSE TYPE

        Public Property l001 As System.String 'LABEL FOR DepCode
        Public Property l002 As System.String 'LABEL FOR DepDesc
        Public Property l003 As System.String 'LABEL FOR OthDesc
        Public Property l004 As System.String 'LABEL FOR ExpTyp

        Public Property isRead As System.Int32
        Public Property rowId As System.Int64
        Public Property rspPrc As processToken
        Public Sub New()
            reset()
        End Sub
        Public Sub New(ByVal _vf001 As System.String,
                       ByVal _vf002 As System.String,
                       ByVal _vf003 As System.String,
                       ByVal _vf004 As System.Int32,
                       ByVal _vl001 As System.String,
                       ByVal _vl002 As System.String,
                       ByVal _vl003 As System.String,
                       ByVal _vl004 As System.String)
            reset()
            _f001 = _vf001
            _f002 = _vf002
            _f003 = _vf003
            _f004 = _vf004
            _l001 = _vl001
            _l002 = _vl002
            _l003 = _vl003
            _l004 = _vl004
        End Sub
        Public Sub reset()
            _modInf = New programModInfo
            _f001 = ""
            _f002 = ""
            _f003 = ""
            _f004 = 0
            _l001 = ""
            _l002 = ""
            _l003 = ""
            _l004 = ""
            _isRead = -1
            _rowId = 1
            _rspPrc = New processToken
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
            Dim prgInfo As New programInfo("SS", "SS07", "")
            Dim departmentData As New departmentProfileData(depCodeFld.Text,
                                                            depDescFld.Text,
                                                            othDescFld.Text,
                                                            expTypFld.SelectedIndex,
                                                            depCodeLbl.Text,
                                                            depDescLbl.Text,
                                                            othDescLbl.Text,
                                                            expTypLbl.Text)
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