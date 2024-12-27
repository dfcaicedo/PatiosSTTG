Public Class Co_tariMOD
    Public tic_codi As Integer
    Public par_Codi As Integer
    Public tiv_codi As Integer
    Public tar_laps As Integer = 1440
    Public tar_codi As Integer
    Public tse_codi As Integer = 1
    Public emp_nusu As String
    Public tar_acti As Boolean
    Public tar_agno As Integer
    Public tar_cost As Long
    Public Sub New()

    End Sub
    Public Sub New(emp_nusu As String, par_codi As Integer)
        Me.emp_nusu = emp_nusu
        Me.par_Codi = par_codi
        Me.tar_agno = DateTime.Now.Year
    End Sub
End Class
