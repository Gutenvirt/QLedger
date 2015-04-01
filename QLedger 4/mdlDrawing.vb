Module mdlDrawing

    Public sBrush As New SolidBrush(Color.Black)
    Public oBrush As New SolidBrush(Color.Red)

    Public sPen As New Pen(Color.Black, 1)
    Public lPen As New Pen(Color.LightGray, 1)

    Public sFont As New Font(FontFamily.GenericMonospace, "22")
    Public sFontBold As New Font(FontFamily.GenericMonospace, "22", FontStyle.Bold, GraphicsUnit.Point)

    Public cFont As New Font(FontFamily.GenericMonospace, "14")

    Public iFont As New Font(FontFamily.GenericMonospace, 12)

    Public iText As New Font(FontFamily.GenericMonospace, 12, FontStyle.Bold)
    Public iBrush As New SolidBrush(Color.Black)

    Public currentCell As Rectangle = New Rectangle(0, 0, 150, 50)
    Public txtFormat As StringFormat = New StringFormat

End Module
