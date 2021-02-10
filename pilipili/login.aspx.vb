Public Class login
    Inherits System.Web.UI.Page
    Dim num As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        num = CType(TextBox7.Text, Integer)
        Label1.Text = Str(num)

    End Sub



    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.TextBox1.Text = "" And Me.TextBox2.Text = "" And Me.TextBox3.Text = "" And Me.TextBox5.Text = "" Then
            Response.Write("<Script Language=JavaScript>alert('请填写完整');</Script>")
        Else
            If Int(Me.TextBox4.Text) >= 18 Then
                Me.Panel1.Visible = False
                Me.Panel2.Visible = False
                Me.Panel3.Visible = True
            Else
                Response.Write("<Script Language=JavaScript>alert('你还太小');</Script>")
            End If
        End If
    End Sub

    Protected Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked = True Then
            Me.Panel1.Visible = True
            Me.Button1.Enabled = True
        Else
            Me.Panel1.Visible = False
        End If
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Button1.Enabled = False
        Response.Write("<Script Language=JavaScript>alert('请等待30秒');</Script>")
        Threading.Thread.Sleep(3000)
        Me.Button1.Enabled = True
        Response.Write("<Script Language=JavaScript>alert('邮箱服务器错误，你无需输入验证码');</Script>")
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Me.FileUpload1.HasFile = False Then
            Response.Write("<Script Language=JavaScript>alert('请上传照片，我们不会告诉任何人！');</Script>")
        Else
            If num >= 15 Then
                Response.Cookies（"login"）.Value = "123"
                Response.Write("<Script Language=JavaScript>window.location.href='./enjoy.aspx';</Script>")
            Else
                Response.Write("<Script Language=JavaScript>alert('请必须选完！');</Script>")
            End If
        End If
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        num = num + 1
        TextBox7.Text = Str(num)
        Label1.Text = Str(num)
        Response.Write("<Script Language=JavaScript>alert('已选择喜欢');</Script>")
        If num = 15 Then
            Response.Write("<Script Language=JavaScript>alert('选完了');</Script>")
            Me.Button4.Enabled = False
            Me.Button5.Enabled = False
            Me.Label1.Text = "完毕"
        End If
        Me.Image1.ImageUrl = "./imge/" + LTrim(Str(num)) + ".jpg"

    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        num = num + 1
        TextBox7.Text = Str(num)
        Label1.Text = Str(num)
        Response.Write("<Script Language=JavaScript>alert('已选择不喜欢');</Script>")
        If num = 15 Then
            Response.Write("<Script Language=JavaScript>alert('选完了');</Script>")
            Me.Button4.Enabled = False
            Me.Button5.Enabled = False
            Me.Label1.Text = "完毕"
        End If
        Me.Image1.ImageUrl = "./imge/" + LTrim(Str(num)) + ".jpg"
    End Sub
End Class