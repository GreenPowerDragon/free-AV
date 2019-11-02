Public Class F1
    Private Sub 激活ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 激活ToolStripMenuItem.Click
        Dim jihuo As String = InputBox("激活码：", "激活")
        Me.ProgressBar1.Value = 30
        If jihuo = "123" Then
            Me.GroupBox1.Visible = True
            Me.ProgressBar1.Value = 60
            Me.Label1.Text = "就绪"
            Me.ProgressBar1.Value = 100
            Threading.Thread.Sleep(600)
            Me.ProgressBar1.Value = 0
        End If

    End Sub

    Private Sub F1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("激活码为123", , "我爱破解赞助")
        MsgBox("请输入激活码")
    End Sub

    Private Sub 打开本地ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 打开本地ToolStripMenuItem.Click
        If (Me.OpenFileDialog1.ShowDialog() = DialogResult.OK) And (OpenFileDialog1.FileName.Length > 0) Then
            MsgBox（"无法打开"）
        End If
    End Sub

    Private Sub 推荐ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 推荐ToolStripMenuItem.Click
        Me.WebBrowser1.Visible = True
    End Sub

    Private Sub 登录ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 登录ToolStripMenuItem1.Click
        Me.WebBrowser1.Visible = True
    End Sub

    Private Sub 关闭ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关闭ToolStripMenuItem.Click
        MsgBox("请观看3分钟")
    End Sub

    Private Sub AV之家ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AV之家ToolStripMenuItem1.Click
        Me.WebBrowser1.Visible = True
    End Sub

    Private Sub 登录ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 登录ToolStripMenuItem.Click
        Me.WebBrowser1.Visible = True
    End Sub

    Private Sub 急速ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 急速ToolStripMenuItem.Click
        Me.WebBrowser1.Visible = True
    End Sub

    Private Sub AV之家ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AV之家ToolStripMenuItem.Click
        Me.WebBrowser1.Visible = True
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem.Click
        MsgBox("请观看3分钟")
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Label1.Text = ("无效用户")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Label1.Text = "已提交申请，3小时后通过，请游客登录"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Label1.Text = "请等待"
        Me.ProgressBar1.Value = 10
        Threading.Thread.Sleep(20)
        Me.ProgressBar1.Value = 40
        Threading.Thread.Sleep(20)
        Me.ProgressBar1.Value = 60
        Threading.Thread.Sleep(20)
        Me.ProgressBar1.Value = 80
        Me.Label1.Text = "已打开"
        Threading.Thread.Sleep(20)
        Me.ProgressBar1.Value = 100
        Threading.Thread.Sleep(20)
    End Sub
End Class