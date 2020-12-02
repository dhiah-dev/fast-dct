Module DCTfunctions
    '''''''''''''' Standard Two Dimension DCT 8 by 8''''''''''''''''''''
    Public Function SDCTTwoDim8by8(ByRef DImage(,) As Single, ByVal W As Integer, ByVal H As Integer, ByVal GImage(,) As Single)


        Dim i, j As Integer
        Dim sum, au, av As Single
        Dim u, v, x, y As Integer
        Dim We, He As Integer

        ''''''''''''''''''''''''''''''''''''''''''''''
        ' Calculate DCT in two dimenssions
        ''''''''''''''''''''''''''''''''''''''''''''''
        We = W - 1 : He = H - 1

        For i = 0 To We Step 8
            For j = 0 To He Step 8
                For u = 0 To 7
                    For v = 0 To 7
                        sum = 0
                        For x = 0 To 7
                            For y = 0 To 7
                                sum = sum + GImage(i + x, j + y) * Math.Cos((3.14 * (2 * x + 1) * u) / 16) * Math.Cos((3.14 * (2 * y + 1) * v) / 16)
                            Next
                        Next
                        If u = 0 Then
                            au = 0.35355339059
                        Else
                            au = 0.5
                        End If
                        If v = 0 Then
                            av = 0.35355339059
                        Else
                            av = 0.5
                        End If

                        DImage(i + u, j + v) = au * av * sum
                    Next
                Next
            Next
        Next

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

     

    End Function
    '''''''''''''' Inverse Standard Two Dimension DCT 8 by 8''''''''''''''''''''
    Public Function SIDCTTwoDim8by8(ByVal DImage(,) As Single, ByVal W As Integer, ByVal H As Integer, ByRef GImage(,) As Single)


        Dim i, j As Integer
        Dim sum, au, av As Single
        Dim u, v, x, y As Integer
        Dim We, He As Integer

        ''''''''''''''''''''''''''''''''''''''''''''''
        ' Calculate DCT in two dimenssions
        ''''''''''''''''''''''''''''''''''''''''''''''
        We = W - 1 : He = H - 1

        For i = 0 To We Step 8
            For j = 0 To He Step 8
                For x = 0 To 7
                    For y = 0 To 7
                        sum = 0
                        For u = 0 To 7
                            For v = 0 To 7
                                If u = 0 Then
                                    au = 0.35355339059
                                Else
                                    au = 0.5
                                End If
                                If v = 0 Then
                                    av = 0.35355339059
                                Else
                                    av = 0.5
                                End If
                                sum = sum + DImage(i + u, j + v) * au * av * Math.Cos((3.14 * (2 * x + 1) * u) / 16) * Math.Cos((3.14 * (2 * y + 1) * v) / 16)
                            Next
                        Next


                        GImage(i + x, j + y) = sum
                    Next
                Next
            Next
        Next

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''



    End Function

    '''''''''''''' One Dimension DCT ''''''''''''''''''''
    Public Function SDCTOneDim8by8(ByRef DImage(,) As Single, ByVal W As Integer, ByVal H As Integer, ByVal GImage(,) As Single)
    

        Dim i, j As Integer
        Dim sum As Single
        Dim u, x, stp As Integer
        Dim DImaget(1500, 1500) As Single
        Dim We, He As Integer

        ''''''''''''''''''''''''''''''''''''''''''''''
        ' Calculate DCT Horizontally
        ''''''''''''''''''''''''''''''''''''''''''''''
        We = W - 1 : He = H - 1

        For i = 0 To We Step 8
            For j = 0 To He Step 8
                For stp = 0 To 7
                    For u = 0 To 7
                        sum = 0
                        For x = 0 To 7
                            sum = sum + GImage(i + stp, j + x) * Math.Cos((3.14 * (2 * x + 1) * u) / 16)
                        Next
                        If u = 0 Then
                            DImaget(i + stp, j + u) = 0.35355339059 * sum
                        Else
                            DImaget(i + stp, j + u) = 0.5 * sum
                        End If
                    Next
                Next
            Next
        Next

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ''''''''''''''''''''''''''''''''''''''''''''''
        ' Calculate DCT Vertically
        ''''''''''''''''''''''''''''''''''''''''''''''

        For i = 0 To We Step 8
            For j = 0 To He Step 8
                For stp = 0 To 7
                    For u = 0 To 7
                        sum = 0
                        For x = 0 To 7
                            sum = sum + DImaget(i + x, j + stp) * Math.Cos((3.14 * (2 * x + 1) * u) / 16)
                        Next
                        If u = 0 Then
                            DImage(i + u, j + stp) = 0.35355339059 * sum
                        Else
                            DImage(i + u, j + stp) = 0.5 * sum
                        End If
                    Next
                Next
            Next
        Next

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    End Function

    '''''''''''''' Inverse One Dimension DCT ''''''''''''''''''''
    Public Function SIDCTOneDim8by8(ByVal DImage(,) As Single, ByVal W As Integer, ByVal H As Integer, ByRef GImage(,) As Single)

        Dim i, j As Integer
        Dim sum As Single
        Dim u, x, stp As Integer
        Dim DImaget(1500, 1500) As Single
        Dim We, He As Integer

        ''''''''''''''''''''''''''''''''''''''''''''''
        ' Calculate DCT Vertically
        ''''''''''''''''''''''''''''''''''''''''''''''
        We = W - 1 : He = H - 1

        For i = 0 To We Step 8
            For j = 0 To He Step 8

                For stp = 0 To 7
                    For x = 0 To 7
                        sum = 0
                        For u = 0 To 7
                            If u = 0 Then
                                sum = sum + DImage(i + u, j + stp) * Math.Cos((3.14 * (2 * x + 1) * u) / 16) * 0.35355339059
                            Else
                                sum = sum + DImage(i + u, j + stp) * Math.Cos((3.14 * (2 * x + 1) * u) / 16) * 0.5
                            End If

                        Next
                        DImaget(i + x, j + stp) = sum

                    Next
                Next
            Next
        Next

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ''''''''''''''''''''''''''''''''''''''''''''''
        ' Calculate DCT Horizontally
        ''''''''''''''''''''''''''''''''''''''''''''''
        For i = 0 To We Step 8
            For j = 0 To He Step 8

                For stp = 0 To 7
                    For x = 0 To 7
                        sum = 0

                        For u = 0 To 7
                            If u = 0 Then
                                sum = sum + DImaget(i + stp, j + u) * Math.Cos((3.14 * (2 * x + 1) * u) / 16) * 0.35355339059
                            Else
                                sum = sum + DImaget(i + stp, j + u) * Math.Cos((3.14 * (2 * x + 1) * u) / 16) * 0.5

                            End If

                        Next
                        GImage(i + stp, j + x) = sum

                    Next
                Next
            Next
        Next

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''



    End Function
    Public Sub FDCT8by8(ByRef DImage(,) As Single, W As Integer, H As Integer, GImage(,) As Single)

        Dim x As Integer, Xs As Integer, Xe As Integer, Xx As Integer
        Dim y As Integer, Ys As Integer, Ye As Integer, Yy As Integer
        Dim F07 As Long, F16 As Long, F25 As Long, F34 As Long, T As Long
        Dim F07m34 As Long, F16m25 As Long, F07p34 As Long, F16p25 As Long
        Dim Tmp(7, 7) As Long, F(7) As Long

        Ys = 0 : Ye = 7
        While Ye < H
            Xs = 0 : Xe = 7
            While Xe < W
                For y = 0 To 7 : Yy = Ys + y
                    For x = 0 To 7 : F(x) = GImage(Xs + x, Yy) : Next x
                    F07 = F(0) - F(7) : F16 = F(1) - F(6)
                    F25 = F(2) - F(5) : F34 = F(3) - F(4)
                    Tmp(1, y) = (49039 * F07 + 41573 * F16 + 27779 * F25 + 9755 * F34 + 1000) \ 8000
                    Tmp(3, y) = (41573 * F07 - 9755 * F16 - 49039 * F25 - 27779 * F34 + 1000) \ 8000
                    Tmp(5, y) = (27779 * F07 - 49039 * F16 + 9755 * F25 + 41573 * F34 + 1000) \ 8000
                    Tmp(7, y) = (9755 * F07 - 27779 * F16 + 41573 * F25 - 49039 * F34 + 1000) \ 8000
                    F07 = F(0) + F(7) : F16 = F(1) + F(6)
                    F25 = F(2) + F(5) : F34 = F(3) + F(4)
                    F07m34 = F07 - F34 : F16m25 = F16 - F25
                    F07p34 = F07 + F34 : F16p25 = F16 + F25
                    Tmp(0, y) = (F07p34 + F16p25) * 4.419375
                    Tmp(2, y) = (46194 * F07m34 + 19134 * F16m25 + 1000) \ 8000
                    Tmp(4, y) = (F07p34 - F16p25) * 4.419375
                    Tmp(6, y) = (19134 * F07m34 - 46194 * F16m25 + 1000) \ 8000
                Next y

                For x = 0 To 7 : Xx = Xs + x
                    For y = 0 To 7 : F(y) = Tmp(x, y) : Next y
                    F07 = F(0) - F(7) : F16 = F(1) - F(6)
                    F25 = F(2) - F(5) : F34 = F(3) - F(4)
                    T = 49039 * F07 + 41573 * F16 + 27779 * F25 + 9755 * F34
                    DImage(Xx, Ys + 1) = T * 0.0000008
                    T = 41573 * F07 - 9755 * F16 - 49039 * F25 - 27779 * F34
                    DImage(Xx, Ys + 3) = T * 0.0000008
                    T = 27779 * F07 - 49039 * F16 + 9755 * F25 + 41573 * F34
                    DImage(Xx, Ys + 5) = T * 0.0000008
                    T = 9755 * F07 - 27779 * F16 + 41573 * F25 - 49039 * F34
                    DImage(Xx, Ys + 7) = T * 0.0000008
                    F07 = F(0) + F(7) : F16 = F(1) + F(6)
                    F25 = F(2) + F(5) : F34 = F(3) + F(4)
                    F07m34 = F07 - F34 : F16m25 = F16 - F25
                    F07p34 = F07 + F34 : F16p25 = F16 + F25
                    DImage(Xx, Ys) = (F07p34 + F16p25) * 0.007071 * 4
                    DImage(Xx, Ys + 2) = 0.0092388 * 4 * F07m34 + 0.0038268 * 4 * F16m25
                    DImage(Xx, Ys + 4) = (F07p34 - F16p25) * 0.007071 * 4
                    DImage(Xx, Ys + 6) = 0.0038268 * 4 * F07m34 - 0.0092388 * 4 * F16m25
                Next x

                Xs = Xs + 8 : Xe = Xe + 8
            End While
            Ys = Ys + 8 : Ye = Ye + 8
        End While
    End Sub

    Public Sub FIDCT8by8(DImage(,) As Single, W As Integer, H As Integer, ByRef GImage(,) As Single)

        Dim x As Integer, Xs As Integer, Xe As Integer, Xx As Integer
        Dim y As Integer, Ys As Integer, Ye As Integer, Yy As Integer
        Dim U04p As Long, U04m As Long, U2p6 As Long, U2m6 As Long, U1p71 As Long
        Dim U1m71 As Long, U1p72 As Long, U1m72 As Long, U3p51 As Long, U3p52 As Long
        Dim U3m51 As Long, U3m52 As Long, Uppp As Long, Upmp As Long, Umpm As Long
        Dim Ummm As Long, Vppp As Long, Vmmp As Long, Vpmm As Long, Vmmm As Long
        Dim T As Long, G(7) As Single, Tmp(7, 7) As Long, Gg(7) As Long


        Ys = 0 : Ye = 7
        While Ye < H
            Xs = 0 : Xe = 7
            While Xe < W
                For y = 0 To 7 : Yy = Ys + y
                    For x = 0 To 7 : G(x) = DImage(Xs + x, Yy) : Next x
                    U04p = 35355 * (G(0) + G(4))
                    U04m = 35355 * (G(0) - G(4))
                    U2p6 = 46194 * G(2) + 19134 * G(6)
                    U2m6 = 19134 * G(2) - 46194 * G(6)
                    U1p71 = 49039 * G(1) + 9755 * G(7)
                    U1m71 = 41573 * G(1) - 27779 * G(7)
                    U1p72 = 27779 * G(1) + 41573 * G(7)
                    U1m72 = 9755 * G(1) - 49039 * G(7)
                    U3p51 = 41573 * G(3) + 27779 * G(5)
                    U3p52 = 9755 * G(3) + 49039 * G(5)
                    U3m51 = 49039 * G(3) - 9755 * G(5)
                    U3m52 = 27779 * G(3) - 41573 * G(5)
                    Uppp = U04p + U2p6 : Upmp = U04p - U2p6
                    Umpm = U04m + U2m6 : Ummm = U04m - U2m6
                    Vppp = U1p71 + U3p51 : Vmmp = U1m71 - U3p52
                    Vpmm = U1p72 - U3m51 : Vmmm = U1m72 - U3m52
                    Tmp(0, y) = (Uppp + Vppp + 1000) \ 2000 : Tmp(1, y) = (Umpm + Vmmp + 1000) \ 2000
                    Tmp(2, y) = (Ummm + Vpmm + 1000) \ 2000 : Tmp(3, y) = (Upmp + Vmmm + 1000) \ 2000
                    Tmp(4, y) = (Upmp - Vmmm + 1000) \ 2000 : Tmp(5, y) = (Ummm - Vpmm + 1000) \ 2000
                    Tmp(6, y) = (Umpm - Vmmp + 1000) \ 2000 : Tmp(7, y) = (Uppp - Vppp + 1000) \ 2000
                Next y

                For x = 0 To 7 : Xx = Xs + x
                    For y = 0 To 7 : Gg(y) = Tmp(x, y) : Next y
                    U04p = 35355 * (Gg(0) + Gg(4))
                    U04m = 35355 * (Gg(0) - Gg(4))
                    U2p6 = 46194 * Gg(2) + 19134 * Gg(6)
                    U2m6 = 19134 * Gg(2) - 46194 * Gg(6)
                    U1p71 = 49039 * Gg(1) + 9755 * Gg(7)
                    U1m71 = 41573 * Gg(1) - 27779 * Gg(7)
                    U1p72 = 27779 * Gg(1) + 41573 * Gg(7)
                    U1m72 = 9755 * Gg(1) - 49039 * Gg(7)
                    U3p51 = 41573 * Gg(3) + 27779 * Gg(5)
                    U3p52 = 9755 * Gg(3) + 49039 * Gg(5)
                    U3m51 = 49039 * Gg(3) - 9755 * Gg(5)
                    U3m52 = 27779 * Gg(3) - 41573 * Gg(5)
                    Uppp = U04p + U2p6 : Upmp = U04p - U2p6
                    Umpm = U04m + U2m6 : Ummm = U04m - U2m6
                    Vppp = U1p71 + U3p51 : Vmmp = U1m71 - U3p52
                    Vpmm = U1p72 - U3m51 : Vmmm = U1m72 - U3m52
                    T = (Uppp + Vppp + 2500000) \ 5000000 : If T < 0 Then T = 0 Else If T > 255 Then T = 255
                    GImage(Xx, Ys) = T
                    T = (Umpm + Vmmp + 2500000) \ 5000000 : If T < 0 Then T = 0 Else If T > 255 Then T = 255
                    GImage(Xx, Ys + 1) = T
                    T = (Ummm + Vpmm + 2500000) \ 5000000 : If T < 0 Then T = 0 Else If T > 255 Then T = 255
                    GImage(Xx, Ys + 2) = T
                    T = (Upmp + Vmmm + 2500000) \ 5000000 : If T < 0 Then T = 0 Else If T > 255 Then T = 255
                    GImage(Xx, Ys + 3) = T
                    T = (Upmp - Vmmm + 2500000) \ 5000000 : If T < 0 Then T = 0 Else If T > 255 Then T = 255
                    GImage(Xx, Ys + 4) = T
                    T = (Ummm - Vpmm + 2500000) \ 5000000 : If T < 0 Then T = 0 Else If T > 255 Then T = 255
                    GImage(Xx, Ys + 5) = T
                    T = (Umpm - Vmmp + 2500000) \ 5000000 : If T < 0 Then T = 0 Else If T > 255 Then T = 255
                    GImage(Xx, Ys + 6) = T
                    T = (Uppp - Vppp + 2500000) \ 5000000 : If T < 0 Then T = 0 Else If T > 255 Then T = 255
                    GImage(Xx, Ys + 7) = T
                Next x

                Xs = Xs + 8 : Xe = Xe + 8
            End While
            Ys = Ys + 8 : Ye = Ye + 8
        End While
    End Sub

    Public Function BitMAP_ColorToSingleGray(ByVal BMPimage As Bitmap, ByRef W As Integer, ByRef H As Integer, ByRef GImage(,) As Single)

        Dim i, j As Integer
        W = BMPimage.Width
        H = BMPimage.Height

        Dim PixelPoint As Color

        For i = 0 To W - 1
            For j = 0 To H - 1
                PixelPoint = BMPimage.GetPixel(i, j)
                GImage(i, j) = (CSng(PixelPoint.R) + CSng(PixelPoint.G) + CSng(PixelPoint.B)) / 3
            Next
        Next


    End Function

    Public Function SingleGrayToBitMAP(ByRef BMPimage As Bitmap, W As Integer, H As Integer, ByVal GImage(,) As Single)

        Dim x, y As Integer
        Dim pixelColor As Color

        Dim R, G, B As Byte

        Dim img As New Bitmap(W, H)

        For x = 0 To W - 1
            For y = 0 To H - 1
                If GImage(x, y) < 0 Then
                    R = 0
                ElseIf GImage(x, y) > 255 Then
                    R = 255
                Else
                    R = CByte(GImage(x, y))
                End If
                G = R : B = R

                pixelColor = Color.FromArgb(R, G, B)
                img.SetPixel(x, y, pixelColor)
            Next
        Next
        BMPimage = img

    End Function
    Public Function MSE(ByVal Image1(,) As Single, ByVal W As Integer, ByVal H As Integer, ByVal Image2(,) As Single) As Single
        Dim i, j As Integer
        Dim sum As Double

        sum = 0
        For i = 0 To W - 1
            For j = 0 To H - 1
                sum = sum + (Image1(i, j) - Image2(i, j)) ^ 2
            Next
        Next
        MSE = sum / (W * H)
    End Function
    Public Function PSNR(ByVal Image1(,) As Single, ByVal W As Integer, ByVal H As Integer, ByVal Image2(,) As Single) As Single
        PSNR = 10 * Math.Log10(CSng(65025) / MSE(Image1, W, H, Image2))
    End Function
End Module
