Public Class main

   

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Load_BMP.Click
        Me.OpenDialog1.Title = "Brows BMP Image"
        Me.OpenDialog1.Filter = "Bit Map Image|*.bmp|Every Thing|*.*"
        ' Me.OpenDialog1.ShowDialog()
        If Me.OpenDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            filereadingflag = True
            grayimageflag = False
            dct2dimflag = False
            dct1dimflag = False
            dctfastflag = False

            img0 = New Bitmap(OpenDialog1.FileName, True)
            pic0.Image = img0
        End If
        
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If grayimageflag Then
            start_time = Now
            SDCTOneDim8by8(DCT1DimImage, ImgWidth, ImgHeight, GrayImage)
            end_time = Now
            elapse_time = end_time.Subtract(start_time)

            SingleGrayToBitMAP(img4, ImgWidth, ImgHeight, DCT1DimImage)

            Me.i3.Text = "Execution Time (ms)= " + elapse_time.TotalMilliseconds.ToString

            pic2.Image = img4
            dct1dimflag = True

        Else
            MessageBox.Show("You need to select an Image file first and convert it to gray level...", "Alert")
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If filereadingflag Then
            BitMAP_ColorToSingleGray(img0, ImgWidth, ImgHeight, GrayImage)

            SingleGrayToBitMAP(img1, ImgWidth, ImgHeight, GrayImage)
            pic1.Image = img1
            grayimageflag = True
        Else
            MessageBox.Show("You need to select an Image file first ...", "Alert")
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If dct1dimflag Then
            start_time = Now
            SIDCTOneDim8by8(DCT1DimImage, ImgWidth, ImgHeight, IDCT1DimImage)
            end_time = Now
            elapse_time = end_time.Subtract(start_time)

            SingleGrayToBitMAP(img5, ImgWidth, ImgHeight, IDCT1DimImage)
            Me.i4.Text = "Execution Time (ms)= " + elapse_time.TotalMilliseconds.ToString + vbNewLine + "MSE= " + CStr(MSE(GrayImage, ImgWidth, ImgHeight, IDCT1DimImage)) + vbNewLine + "PSNR= " + CStr(PSNR(GrayImage, ImgWidth, ImgHeight, IDCT1DimImage))

            pic3.Image = img5

        Else
            MessageBox.Show("You need to perform the transform first ...", "Alert")
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        If grayimageflag Then
            start_time = Now
            FDCT8by8(FDCTImage, ImgWidth, ImgHeight, GrayImage)
            end_time = Now
            elapse_time = end_time.Subtract(start_time)

            SingleGrayToBitMAP(img6, ImgWidth, ImgHeight, FDCTImage)

            Me.i5.Text = "Execution Time (ms)= " + elapse_time.TotalMilliseconds.ToString

            pic4.Image = img6
            dctfastflag = True

        Else
            MessageBox.Show("You need to select an Image file first and convert it to gray level...", "Alert")
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If dctfastflag Then
            start_time = Now
            FIDCT8by8(FDCTImage, ImgWidth, ImgHeight, FIDCTImage)
            end_time = Now
            elapse_time = end_time.Subtract(start_time)

            SingleGrayToBitMAP(img7, ImgWidth, ImgHeight, FIDCTImage)
            Me.i6.Text = "Execution Time (ms)= " + elapse_time.TotalMilliseconds.ToString + vbNewLine + "MSE= " + CStr(MSE(GrayImage, ImgWidth, ImgHeight, FIDCTImage)) + vbNewLine + "PSNR= " + CStr(PSNR(GrayImage, ImgWidth, ImgHeight, FIDCTImage))

            pic5.Image = img7

        Else
            MessageBox.Show("You need to perform the transform first ...", "Alert")
        End If
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If grayimageflag Then
            start_time = Now
            SDCTTwoDim8by8(DCT2DimImage, ImgWidth, ImgHeight, GrayImage)
            end_time = Now
            elapse_time = end_time.Subtract(start_time)

            SingleGrayToBitMAP(img2, ImgWidth, ImgHeight, DCT2DimImage)

            Me.i1.Text = "Execution Time (ms)= " + elapse_time.TotalMilliseconds.ToString

            pic6.Image = img2
            dct2dimflag = True


        Else
            MessageBox.Show("You need to select an Image file first and convert it to gray level...", "Alert")
        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If dct2dimflag Then
            start_time = Now
            SIDCTTwoDim8by8(DCT2DimImage, ImgWidth, ImgHeight, IDCT2DimImage)
            end_time = Now
            elapse_time = end_time.Subtract(start_time)

            SingleGrayToBitMAP(img3, ImgWidth, ImgHeight, IDCT2DimImage)
            Me.i2.Text = "Execution Time (ms)= " + elapse_time.TotalMilliseconds.ToString + vbNewLine + "MSE= " + CStr(MSE(GrayImage, ImgWidth, ImgHeight, IDCT2DimImage)) + vbNewLine + "PSNR= " + CStr(PSNR(GrayImage, ImgWidth, ImgHeight, IDCT2DimImage))

            pic7.Image = img3
        Else
            MessageBox.Show("You need to perform the transform first ...", "Alert")
        End If

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        ' 1: ---------  reading
        Me.OpenDialog1.Title = "Brows BMP Image"
        Me.OpenDialog1.Filter = "Bit Map Image|*.bmp|Every Thing|*.*"

        If Me.OpenDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            filereadingflag = True

            img0 = New Bitmap(OpenDialog1.FileName, True)
            pic0.Image = img0
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Me.Refresh()

            '2: Build gray image from bitmap
            BitMAP_ColorToSingleGray(img0, ImgWidth, ImgHeight, GrayImage)
            SingleGrayToBitMAP(img1, ImgWidth, ImgHeight, GrayImage)
            pic1.Image = img1
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Me.Refresh()

            '3: Standard two dim dct
            start_time = Now
            SDCTTwoDim8by8(DCT2DimImage, ImgWidth, ImgHeight, GrayImage)
            end_time = Now
            elapse_time = end_time.Subtract(start_time)
            SingleGrayToBitMAP(img2, ImgWidth, ImgHeight, DCT2DimImage)
            Me.i1.Text = "Execution Time (ms)= " + elapse_time.TotalMilliseconds.ToString
            pic6.Image = img2
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Me.Refresh()

            '4: Inverse Standard two dim dct
            start_time = Now
            SIDCTTwoDim8by8(DCT2DimImage, ImgWidth, ImgHeight, IDCT2DimImage)
            end_time = Now
            elapse_time = end_time.Subtract(start_time)
            SingleGrayToBitMAP(img3, ImgWidth, ImgHeight, IDCT2DimImage)
            Me.i2.Text = "Execution Time (ms)= " + elapse_time.TotalMilliseconds.ToString + vbNewLine + "MSE= " + CStr(MSE(GrayImage, ImgWidth, ImgHeight, IDCT2DimImage)) + vbNewLine + "PSNR= " + CStr(PSNR(GrayImage, ImgWidth, ImgHeight, IDCT2DimImage))
            pic7.Image = img3
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Me.Refresh()

            '5: Standard one dim dct
            start_time = Now
            SDCTOneDim8by8(DCT1DimImage, ImgWidth, ImgHeight, GrayImage)
            end_time = Now
            elapse_time = end_time.Subtract(start_time)
            SingleGrayToBitMAP(img4, ImgWidth, ImgHeight, DCT1DimImage)
            Me.i3.Text = "Execution Time (ms)= " + elapse_time.TotalMilliseconds.ToString
            pic2.Image = img4
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Me.Refresh()

            '6: Inverse Standard one dim dct
            start_time = Now
            SIDCTOneDim8by8(DCT1DimImage, ImgWidth, ImgHeight, IDCT1DimImage)
            end_time = Now
            elapse_time = end_time.Subtract(start_time)
            SingleGrayToBitMAP(img5, ImgWidth, ImgHeight, IDCT1DimImage)
            Me.i4.Text = "Execution Time (ms)= " + elapse_time.TotalMilliseconds.ToString + vbNewLine + "MSE= " + CStr(MSE(GrayImage, ImgWidth, ImgHeight, IDCT1DimImage)) + vbNewLine + "PSNR= " + CStr(PSNR(GrayImage, ImgWidth, ImgHeight, IDCT1DimImage))
            pic3.Image = img5
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Me.Refresh()

            '7: Fast dct
            start_time = Now
            FDCT8by8(FDCTImage, ImgWidth, ImgHeight, GrayImage)
            end_time = Now
            elapse_time = end_time.Subtract(start_time)
            SingleGrayToBitMAP(img6, ImgWidth, ImgHeight, FDCTImage)
            Me.i5.Text = "Execution Time (ms)= " + elapse_time.TotalMilliseconds.ToString
            pic4.Image = img6
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Me.Refresh()

            '8: Inverse Fast dct
            start_time = Now
            FIDCT8by8(FDCTImage, ImgWidth, ImgHeight, FIDCTImage)
            end_time = Now
            elapse_time = end_time.Subtract(start_time)
            SingleGrayToBitMAP(img7, ImgWidth, ImgHeight, FIDCTImage)
            Me.i6.Text = "Execution Time (ms)= " + elapse_time.TotalMilliseconds.ToString + vbNewLine + "MSE= " + CStr(MSE(GrayImage, ImgWidth, ImgHeight, FIDCTImage)) + vbNewLine + "PSNR= " + CStr(PSNR(GrayImage, ImgWidth, ImgHeight, FIDCTImage))
            pic5.Image = img7
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Me.Refresh()
        End If


    End Sub

   
    Private Sub pic0_Click(sender As Object, e As EventArgs) Handles pic0.Click
        If Not pic0.Image Is Nothing Then
            Me.SaveFileDialog1.Title = "Select a Place for your Bitmap file"
            Me.SaveFileDialog1.Filter = "Bit Map Image|*.bmp"
            If Me.SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                img0.Save(Me.SaveFileDialog1.FileName)
            End If

        End If

    End Sub

    Private Sub pic6_Click(sender As Object, e As EventArgs) Handles pic6.Click
        If Not pic6.Image Is Nothing Then

            Me.SaveFileDialog1.Title = "Select a Place for your Bitmap file"
            Me.SaveFileDialog1.Filter = "Bit Map Image|*.bmp"
            If Me.SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                img2.Save(Me.SaveFileDialog1.FileName)
            End If
        End If

    End Sub

    Private Sub pic1_Click(sender As Object, e As EventArgs) Handles pic1.Click
        If Not pic1.Image Is Nothing Then

            Me.SaveFileDialog1.Title = "Select a Place for your Bitmap file"
            Me.SaveFileDialog1.Filter = "Bit Map Image|*.bmp"
            If Me.SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                img1.Save(Me.SaveFileDialog1.FileName)
            End If
        End If

    End Sub

    Private Sub pic7_Click(sender As Object, e As EventArgs) Handles pic7.Click
        If Not pic7.Image Is Nothing Then

            Me.SaveFileDialog1.Title = "Select a Place for your Bitmap file"
            Me.SaveFileDialog1.Filter = "Bit Map Image|*.bmp"
            If Me.SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                img3.Save(Me.SaveFileDialog1.FileName)
            End If
        End If

    End Sub

    Private Sub pic2_Click(sender As Object, e As EventArgs) Handles pic2.Click
        If Not pic2.Image Is Nothing Then

            Me.SaveFileDialog1.Title = "Select a Place for your Bitmap file"
            Me.SaveFileDialog1.Filter = "Bit Map Image|*.bmp"
            If Me.SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                img4.Save(Me.SaveFileDialog1.FileName)
            End If
        End If

    End Sub

    Private Sub pic3_Click(sender As Object, e As EventArgs) Handles pic3.Click
        If Not pic3.Image Is Nothing Then

            Me.SaveFileDialog1.Title = "Select a Place for your Bitmap file"
            Me.SaveFileDialog1.Filter = "Bit Map Image|*.bmp"
            If Me.SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                img5.Save(Me.SaveFileDialog1.FileName)
            End If
        End If

    End Sub

    Private Sub pic4_Click(sender As Object, e As EventArgs) Handles pic4.Click
        If Not pic4.Image Is Nothing Then

            Me.SaveFileDialog1.Title = "Select a Place for your Bitmap file"
            Me.SaveFileDialog1.Filter = "Bit Map Image|*.bmp"
            If Me.SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                img6.Save(Me.SaveFileDialog1.FileName)
            End If
        End If

    End Sub

    Private Sub pic5_Click(sender As Object, e As EventArgs) Handles pic5.Click
        If Not pic5.Image Is Nothing Then

            Me.SaveFileDialog1.Title = "Select a Place for your Bitmap file"
            Me.SaveFileDialog1.Filter = "Bit Map Image|*.bmp"
            If Me.SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                img7.Save(Me.SaveFileDialog1.FileName)
            End If
        End If

    End Sub
End Class
