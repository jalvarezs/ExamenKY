Public NotInheritable Class SplashScreen

    Dim splashTimer As Timer

    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        splashTimer = New Timer()
        AddHandler splashTimer.Tick, AddressOf TimerTick
        splashTimer.Interval = 2200
        splashTimer.Start()

    End Sub

    Private Sub TimerTick()
        ' Luego de un tick
        splashTimer.Stop()
        Me.Hide()

        ' Se abre el form principal
        Dim f As New FormLogin
        f.ShowDialog()

        ' Al cerrar el principal finaliza el programa
        Me.Close()
    End Sub

End Class
