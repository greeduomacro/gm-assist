Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Data


Public Class GMAssistMain

    <DllImport("user32.dll")> _
    Private Shared Function SetForegroundWindow(ByVal hWnd As IntPtr) As Boolean
    End Function

    Private Function NumbersOnly(ByVal pstrChar As Char, ByVal oTextBox As TextBox) As Boolean
        'validate the entry for a textbox limiting it to only numeric values and the decimal point
        If (Convert.ToString(pstrChar) = "." And InStr(oTextBox.Text, ".")) Then Return True 'accept only one instance of the decimal point
        If Convert.ToString(pstrChar) <> "." And pstrChar <> vbBack Then
            Return IIf(IsNumeric(pstrChar), False, True) 'check if numeric is returned
        End If
        Return False 'for backspace
    End Function

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        e.Handled = NumbersOnly(e.KeyChar, TextBox1)
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        e.Handled = NumbersOnly(e.KeyChar, TextBox2)
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        e.Handled = NumbersOnly(e.KeyChar, TextBox3)
    End Sub

    Private Sub CreditsToolStripMenuItem_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditsToolStripMenuItem.CheckStateChanged
        MessageBox.Show("GM Assist was written by PappaSmurf.  Pleave visit http://code.google.com/p/gm-assist/ for more information.")
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If CheckBox2.Checked <> True Then

            Dim procs As Process() = Process.GetProcessesByName("Client")
            ' don't use .exe extension here
            If procs.Length = 0 Then
                MessageBox.Show("Please Start the Ultima Online Client and Try Again")
                Me.Dispose()
            Else
                Dim hWnd As IntPtr = procs(0).MainWindowHandle
                SetForegroundWindow(hWnd)

                Thread.Sleep(40)
                ' Needed delay to keep from missing SendKeys due to rapid sending
                SendKeys.SendWait("[")
                Thread.Sleep(40)
                SendKeys.SendWait("BC")
                Thread.Sleep(40)
                SendKeys.SendWait(" ")
                Thread.Sleep(40)
                SendKeys.SendWait(TextBox6.Text)
                Thread.Sleep(40)
                SendKeys.SendWait("{ENTER}")
            End If

        ElseIf CheckBox2.Checked = True Then
            Dim procs As Process() = Process.GetProcessesByName("UOSA")
            'Don't use .exe here when identifying a process
            If procs.Length = 0 Then
                MessageBox.Show("Please Start the Ultima Online: Stygian Abyss Client and Try Again")
                Me.Dispose()
            Else
                Dim hWnd As IntPtr = procs(0).MainWindowHandle
                SetForegroundWindow(hWnd)

                Thread.Sleep(40)
                ' Needed delay to keep from missing SendKeys due to rapid sending
                SendKeys.SendWait("[")
                Thread.Sleep(40)
                SendKeys.SendWait("BC")
                Thread.Sleep(40)
                SendKeys.SendWait(" ")
                Thread.Sleep(40)
                SendKeys.SendWait(TextBox6.Text)
                Thread.Sleep(40)
                SendKeys.SendWait("{ENTER}")
            End If
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If CheckBox2.Checked <> True Then

            Dim procs As Process() = Process.GetProcessesByName("Client")
            ' don't use .exe extension here
            If procs.Length = 0 Then
                MessageBox.Show("Please Start the Ultima Online Client and Try Again")
                Me.Dispose()
            Else
                Dim hWnd As IntPtr = procs(0).MainWindowHandle
                SetForegroundWindow(hWnd)

                Thread.Sleep(40)
                ' Needed delay to keep from missing SendKeys due to rapid sending
                SendKeys.SendWait("[")
                Thread.Sleep(40)
                SendKeys.SendWait("Tell ")
                Thread.Sleep(40)
                SendKeys.SendWait("")
                Thread.Sleep(40)
                SendKeys.SendWait(TextBox6.Text)
                Thread.Sleep(40)
                SendKeys.SendWait("{ENTER}")
            End If

        ElseIf CheckBox2.Checked = True Then
            Dim procs As Process() = Process.GetProcessesByName("UOSA")
            'Don't use .exe here when identifying a process
            If procs.Length = 0 Then
                MessageBox.Show("Please Start the Ultima Online: Stygian Abyss Client and Try Again")
                Me.Dispose()
            Else
                Dim hWnd As IntPtr = procs(0).MainWindowHandle
                SetForegroundWindow(hWnd)

                Thread.Sleep(40)
                ' Needed delay to keep from missing SendKeys due to rapid sending
                SendKeys.SendWait("[")
                Thread.Sleep(40)
                SendKeys.SendWait("Tell ")
                Thread.Sleep(40)
                SendKeys.SendWait("")
                Thread.Sleep(40)
                SendKeys.SendWait(TextBox6.Text)
                Thread.Sleep(40)
                SendKeys.SendWait("{ENTER}")
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If CheckBox2.Checked <> True Then

            Dim procs As Process() = Process.GetProcessesByName("Client")
            ' don't use .exe extension here
            If procs.Length = 0 Then
                MessageBox.Show("Please Start the Ultima Online Client and Try Again")
                Me.Dispose()
            Else
                Dim hWnd As IntPtr = procs(0).MainWindowHandle
                SetForegroundWindow(hWnd)

                Thread.Sleep(40)
                ' Needed delay to keep from missing SendKeys due to rapid sending
                SendKeys.SendWait("[")
                Thread.Sleep(40)
                SendKeys.SendWait("Remove")
                Thread.Sleep(40)
                SendKeys.SendWait("{ENTER}")
            End If

        ElseIf CheckBox2.Checked = True Then
            Dim procs As Process() = Process.GetProcessesByName("UOSA")
            'Don't use .exe here when identifying a process
            If procs.Length = 0 Then
                MessageBox.Show("Please Start the Ultima Online: Stygian Abyss Client and Try Again")
                Me.Dispose()
            Else
                Dim hWnd As IntPtr = procs(0).MainWindowHandle
                SetForegroundWindow(hWnd)

                Thread.Sleep(40)
                ' Needed delay to keep from missing SendKeys due to rapid sending
                SendKeys.SendWait("[")
                Thread.Sleep(40)
                SendKeys.SendWait("Remove")
                Thread.Sleep(40)
                SendKeys.SendWait("{ENTER}")
            End If
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If CheckBox2.Checked <> True Then

            Dim procs As Process() = Process.GetProcessesByName("Client")
            ' don't use .exe extension here
            If procs.Length = 0 Then
                MessageBox.Show("Please Start the Ultima Online Client and Try Again")
                Me.Dispose()
            Else
                Dim hWnd As IntPtr = procs(0).MainWindowHandle
                SetForegroundWindow(hWnd)

                Thread.Sleep(40)
                ' Needed delay to keep from missing SendKeys due to rapid sending
                SendKeys.SendWait("[")
                Thread.Sleep(40)
                SendKeys.SendWait("Pages")
                Thread.Sleep(40)
                SendKeys.SendWait("{ENTER}")
            End If

        ElseIf CheckBox2.Checked = True Then
            Dim procs As Process() = Process.GetProcessesByName("UOSA")
            'Don't use .exe here when identifying a process
            If procs.Length = 0 Then
                MessageBox.Show("Please Start the Ultima Online: Stygian Abyss Client and Try Again")
                Me.Dispose()
            Else
                Dim hWnd As IntPtr = procs(0).MainWindowHandle
                SetForegroundWindow(hWnd)

                Thread.Sleep(40)
                ' Needed delay to keep from missing SendKeys due to rapid sending
                SendKeys.SendWait("[")
                Thread.Sleep(40)
                SendKeys.SendWait("Pages")
                Thread.Sleep(40)
                SendKeys.SendWait("{ENTER}")
            End If
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If CheckBox2.Checked <> True Then

            Dim procs As Process() = Process.GetProcessesByName("Client")
            ' don't use .exe extension here
            If procs.Length = 0 Then
                MessageBox.Show("Please Start the Ultima Online Client and Try Again")
                Me.Dispose()
            Else
                Dim hWnd As IntPtr = procs(0).MainWindowHandle
                SetForegroundWindow(hWnd)

                Thread.Sleep(40)
                ' Needed delay to keep from missing SendKeys due to rapid sending
                SendKeys.SendWait("[")
                Thread.Sleep(40)
                SendKeys.SendWait("Move")
                Thread.Sleep(40)
                SendKeys.SendWait("{ENTER}")
            End If

        ElseIf CheckBox2.Checked = True Then
            Dim procs As Process() = Process.GetProcessesByName("UOSA")
            'Don't use .exe here when identifying a process
            If procs.Length = 0 Then
                MessageBox.Show("Please Start the Ultima Online: Stygian Abyss Client and Try Again")
                Me.Dispose()
            Else
                Dim hWnd As IntPtr = procs(0).MainWindowHandle
                SetForegroundWindow(hWnd)

                Thread.Sleep(40)
                ' Needed delay to keep from missing SendKeys due to rapid sending
                SendKeys.SendWait("[")
                Thread.Sleep(40)
                SendKeys.SendWait("Move")
                Thread.Sleep(40)
                SendKeys.SendWait("{ENTER}")
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox2.Checked <> True Then

            Dim procs As Process() = Process.GetProcessesByName("Client")
            ' don't use .exe extension here
            If procs.Length = 0 Then
                MessageBox.Show("Please Start the Ultima Online Client and Try Again")
                Me.Dispose()
            Else
                Dim hWnd As IntPtr = procs(0).MainWindowHandle
                SetForegroundWindow(hWnd)

                Thread.Sleep(40)
                ' Needed delay to keep from missing SendKeys due to rapid sending
                SendKeys.SendWait("[")
                Thread.Sleep(50)
                SendKeys.SendWait("go")
                Thread.Sleep(50)
                SendKeys.SendWait(" ")
                Thread.Sleep(50)
                SendKeys.SendWait(TextBox1.Text)
                Thread.Sleep(50)
                SendKeys.SendWait(" ")
                Thread.Sleep(50)
                SendKeys.SendWait(TextBox2.Text)
                Thread.Sleep(50)
                SendKeys.SendWait(" ")
                Thread.Sleep(50)
                SendKeys.SendWait(TextBox3.Text)
                Thread.Sleep(50)
                SendKeys.SendWait("{ENTER}")
            End If

        ElseIf CheckBox2.Checked = True Then
            Dim procs As Process() = Process.GetProcessesByName("UOSA")
            'Don't use .exe here when identifying a process
            If procs.Length = 0 Then
                MessageBox.Show("Please Start the Ultima Online: Stygian Abyss Client and Try Again")
                Me.Dispose()
            Else
                Dim hWnd As IntPtr = procs(0).MainWindowHandle
                SetForegroundWindow(hWnd)

                Thread.Sleep(40)
                ' Needed delay to keep from missing SendKeys due to rapid sending
                SendKeys.SendWait("[")
                Thread.Sleep(40)
                SendKeys.SendWait("go")
                Thread.Sleep(40)
                SendKeys.SendWait(" ")
                Thread.Sleep(40)
                SendKeys.SendWait(TextBox1.Text)
                Thread.Sleep(40)
                SendKeys.SendWait(" ")
                Thread.Sleep(40)
                SendKeys.SendWait(TextBox2.Text)
                Thread.Sleep(40)
                SendKeys.SendWait(" ")
                Thread.Sleep(40)
                SendKeys.SendWait(TextBox3.Text)
                SendKeys.SendWait(40)
                SendKeys.SendWait("{ENTER}")
            End If
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If CheckBox2.Checked <> True Then

            Dim procs As Process() = Process.GetProcessesByName("Client")
            ' don't use .exe extension here
            If procs.Length = 0 Then
                MessageBox.Show("Please Start the Ultima Online Client and Try Again")
                Me.Dispose()
            Else
                Dim hWnd As IntPtr = procs(0).MainWindowHandle
                SetForegroundWindow(hWnd)

                Thread.Sleep(40)
                ' Needed delay to keep from missing SendKeys due to rapid sending
                SendKeys.SendWait("[")
                Thread.Sleep(40)
                SendKeys.SendWait("addtopack")
                Thread.Sleep(40)
                SendKeys.SendWait(" ")
                Thread.Sleep(40)
                SendKeys.SendWait(TextBox5.Text)
                Thread.Sleep(40)
                SendKeys.SendWait("{ENTER}")
            End If

        ElseIf CheckBox2.Checked = True Then
            Dim procs As Process() = Process.GetProcessesByName("UOSA")
            'Don't use .exe here when identifying a process
            If procs.Length = 0 Then
                MessageBox.Show("Please Start the Ultima Online: Stygian Abyss Client and Try Again")
                Me.Dispose()
            Else
                Dim hWnd As IntPtr = procs(0).MainWindowHandle
                SetForegroundWindow(hWnd)

                Thread.Sleep(40)
                ' Needed delay to keep from missing SendKeys due to rapid sending
                SendKeys.SendWait("[")
                Thread.Sleep(40)
                SendKeys.SendWait("addtopack")
                Thread.Sleep(40)
                SendKeys.SendWait(" ")
                Thread.Sleep(40)
                SendKeys.SendWait(TextBox5.Text)
                Thread.Sleep(40)
                SendKeys.SendWait("{ENTER}")
            End If
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If CheckBox2.Checked <> True Then

            Dim procs As Process() = Process.GetProcessesByName("Client")
            ' don't use .exe extension here
            If procs.Length = 0 Then
                MessageBox.Show("Please Start the Ultima Online Client and Try Again")
                Me.Dispose()
            Else
                Dim hWnd As IntPtr = procs(0).MainWindowHandle
                SetForegroundWindow(hWnd)

                Thread.Sleep(40)
                ' Needed delay to keep from missing SendKeys due to rapid sending
                SendKeys.SendWait("[")
                Thread.Sleep(40)
                SendKeys.SendWait("Tele")
                Thread.Sleep(40)
                SendKeys.SendWait("{ENTER}")
            End If

        ElseIf CheckBox2.Checked = True Then
            Dim procs As Process() = Process.GetProcessesByName("UOSA")
            'Don't use .exe here when identifying a process
            If procs.Length = 0 Then
                MessageBox.Show("Please Start the Ultima Online: Stygian Abyss Client and Try Again")
                Me.Dispose()
            Else
                Dim hWnd As IntPtr = procs(0).MainWindowHandle
                SetForegroundWindow(hWnd)

                Thread.Sleep(40)
                ' Needed delay to keep from missing SendKeys due to rapid sending
                SendKeys.SendWait("[")
                Thread.Sleep(40)
                SendKeys.SendWait("Tele")
                Thread.Sleep(40)
                SendKeys.SendWait("{ENTER}")
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If CheckBox2.Checked <> True Then

            Dim procs As Process() = Process.GetProcessesByName("Client")
            ' don't use .exe extension here
            If procs.Length = 0 Then
                MessageBox.Show("Please Start the Ultima Online Client and Try Again")
                Me.Dispose()
            Else
                Dim hWnd As IntPtr = procs(0).MainWindowHandle
                SetForegroundWindow(hWnd)

                Thread.Sleep(40)
                ' Needed delay to keep from missing SendKeys due to rapid sending
                SendKeys.SendWait("[")
                If CheckBox1.Checked = True Then
                    SendKeys.SendWait("m ")
                End If
                Thread.Sleep(40)
                SendKeys.SendWait("add")
                Thread.Sleep(40)
                SendKeys.SendWait(" ")
                Thread.Sleep(40)
                SendKeys.SendWait(TextBox4.Text)
                Thread.Sleep(40)
                SendKeys.SendWait("{ENTER}")
            End If

        ElseIf CheckBox2.Checked = True Then
            Dim procs As Process() = Process.GetProcessesByName("UOSA")
            'Don't use .exe here when identifying a process
            If procs.Length = 0 Then
                MessageBox.Show("Please Start the Ultima Online: Stygian Abyss Client and Try Again")
                Me.Dispose()
            Else
                Dim hWnd As IntPtr = procs(0).MainWindowHandle
                SetForegroundWindow(hWnd)

                Thread.Sleep(40)
                ' Needed delay to keep from missing SendKeys due to rapid sending
                SendKeys.SendWait("[")
                If CheckBox1.Checked = True Then
                    SendKeys.SendWait("m ")
                End If
                Thread.Sleep(40)
                SendKeys.SendWait("add")
                Thread.Sleep(40)
                SendKeys.SendWait(" ")
                Thread.Sleep(40)
                SendKeys.SendWait(TextBox4.Text)
                Thread.Sleep(40)
                SendKeys.SendWait("{ENTER}")
            End If
        End If
    End Sub
End Class
