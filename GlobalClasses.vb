Public Module GlobalClasses
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

    
#End Region
End Module
