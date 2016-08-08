Public Class Form1
    ' variables of Colours and Forms
    Dim GraphicsFun As Graphics
    Dim Pencolor_Red As New Pen(Color.Red)
    Dim PenColor_Blue As New Pen(Color.Blue)
    Dim BrushColor_Green As New SolidBrush(Color.Green)
    Dim BrushColor_Red As New SolidBrush(Color.Red)
    Dim BrushColor_Pink As New SolidBrush(Color.Pink)
    Dim BrushColor_Purple As New SolidBrush(Color.Purple)
    Dim BrushColor_Blue As New SolidBrush(Color.Blue)

    Dim Points() As Point = {New Point(358, 280), New Point(300, 320), New Point(275, 155), New Point(350, 180)}

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Line 

        GraphicsFun = Me.CreateGraphics
        GraphicsFun.DrawLine(PenColor_Blue, 30, 50, 250, 250)
        GraphicsFun.DrawLine(PenColor_Blue, 250, 250, 30, 150)
        GraphicsFun.DrawLine(PenColor_Blue, 50, 30, 250, 250)
        GraphicsFun.DrawLine(PenColor_Blue, 90, 10, 250, 250)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' Rectangle

        ' Draw Rectangle
        GraphicsFun.DrawRectangle(Pencolor_Red, 380, 150, 240, 200)
        GraphicsFun.DrawRectangle(Pencolor_Red, 395, 190, 220, 180)


        ' Fill Rectangle
        GraphicsFun.FillRectangle(BrushColor_Red, 150, 10, 250, 100)
        GraphicsFun.FillRectangle(BrushColor_Pink, 160, 18, 230, 85)
        GraphicsFun.FillRectangle(BrushColor_Purple, 175, 30, 200, 60)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' Ellipse

        ' Draw Ellpise
        GraphicsFun.DrawEllipse(PenColor_Blue, 10, 120, 200, 160)
        GraphicsFun.DrawEllipse(PenColor_Blue, 20, 150, 150, 120)
        GraphicsFun.DrawEllipse(PenColor_Blue, 40, 190, 170, 150)

        ' Fill Ellipse
        GraphicsFun.FillEllipse(BrushColor_Red, 300, 200, 150, 120)
        GraphicsFun.FillEllipse(BrushColor_Pink, 310, 210, 130, 100)
        GraphicsFun.FillEllipse(BrushColor_Purple, 320, 220, 110, 80)


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        ' Special form

        For tension As Single = 0 To 2.5 Step 0.5
            GraphicsFun.DrawCurve(Pens.DodgerBlue, Points, tension)
        Next
    End Sub
End Class
