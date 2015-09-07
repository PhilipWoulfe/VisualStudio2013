Public Class Form1
    Dim image As Image
    Dim oldImage As Image

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load an image in from a file
        image = New Bitmap("E:\Libraries\My Pictures\Picture.png")

        'Set our picture box to that image
        PictureBox1.Image = image.Clone()

        'Store our old image so we can delete it
        oldImage = PictureBox1.Image

        Go()

    End Sub

    Function RotateImage(image As Image, angle As Double)



        'create a new empty bitmap to hold rotated image
        Dim rotatedBmp As New Bitmap(image.Width, image.Height)
        rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution)

        'make a graphics object from the empty bitmap
        Dim g As Graphics = Graphics.FromImage(rotatedBmp)

        'Put the rotation point in the center of the image
        g.TranslateTransform(Me.Width / 2, Me.Height / 2)

        'rotate the image
        g.RotateTransform(angle)

        'move the image back
        'g.TranslateTransform(-offset.X, -offset.Y)

        'draw passed in image onto graphics object
        g.DrawImage(image, New PointF(0, 0))

        Return rotatedBmp
    End Function

    Function go()
        
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Pass in our original image and return a new image rotated 35 degrees right
        For i As Integer = 0 To 1
            PictureBox1.Image = RotateImage(image, 1)

            oldImage.Dispose()
            System.Threading.Thread.Sleep(1000)
        Next i
    End Sub
End Class
