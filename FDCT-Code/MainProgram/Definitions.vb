Module Definitions
    Public img0 As Bitmap
    Public img1 As Bitmap
    Public img2 As Bitmap
    Public img3 As Bitmap
    Public img4 As Bitmap
    Public img5 As Bitmap
    Public img6 As Bitmap
    Public img7 As Bitmap

    Public img0flag As Boolean
    Public img1flag As Boolean
    Public img2flag As Boolean
    Public img3flag As Boolean
    Public img4flag As Boolean
    Public img5flag As Boolean
    Public img6flag As Boolean
    Public img7flag As Boolean

    Public filereadingflag As Boolean = False
    Public grayimageflag As Boolean = False
    Public dct2dimflag As Boolean = False
    Public dct1dimflag As Boolean = False
    Public dctfastflag As Boolean = False

    Public ImgWidth As Integer
    Public ImgHeight As Integer
    Public GrayImage(1500, 1500) As Single
    Public DCT1DimImage(1500, 1500) As Single
    Public IDCT1DimImage(1500, 1500) As Single
    Public DCT2DimImage(1500, 1500) As Single
    Public IDCT2DimImage(1500, 1500) As Single
    Public FDCTImage(1500, 1500) As Single
    Public FIDCTImage(1500, 1500) As Single

    Public DCTImaget(1500, 1500) As Single

    Public start_time As DateTime
    Public end_time As DateTime
    Public elapse_time As TimeSpan

End Module
