Dim Log : Log = ""
const Name = "Angelika_Ushakova_Task"

If WScript.Arguments.Count = 1 Then
  If MsgBox ("������� ����� bin � obj �� ���� ������� ������� " & WScript.Arguments(0) & "?", 36, "�������� �����") = 6 Then
    DeleteFolder(WScript.Arguments(0))
  End If 
 
ElseIf WScript.Arguments.Count > 1 Then
  If MsgBox ("������� ����� bin � obj �� ���� ������� ���� �������?", 36, "�������� �����") = 6 Then
    For i = 1 To WScript.Arguments.Count
      DeleteFolder(WScript.Arguments(i-1))
    Next
  End If
 
Else

  Dim Number
  Number = InputBox("������� �����. ������� 0 ��� �������� ����� �� ���� ��������: ", "���� ������")
  If Number <> "" then 
    If Number = "0" Then
      If MsgBox ("������� ����� bin � obj �� ���� �������? ", 36, "�������� �����") = 6 Then
        For i = 1 To 9  
          DeleteFolder(Name & "0" & i)
        Next
        For i = 10 To 99
          DeleteFolder(Name & i)
        Next
      End If
    Else
      If MsgBox ("������� ����� bin � obj �� ���� ������� ������� " & Name & Number & "?", 36, "�������� �����") = 6 Then
        DeleteFolder(Name & Number)
      End If
    End If
  End If
End If

If Log <> "" Then MsgBox "��������� ����� ���� �������: " & vbCrLf & Log, 64, "�������� �����"

Sub DeleteFolder(FolderName)
  Set FSo = CreateObject("Scripting.FileSystemObject")
  If Not FSo.FolderExists(FolderName) Then Exit Sub
  Set Folder = FSo.GetFolder(FolderName)
  
  For Each Task In Folder.SubFolders
    If FSo.FolderExists(Task.Path & "\bin") Then 
      Log = Log & Folder.Name & "\" & Task.Name & "\bin"& vbCrLf 
      FSo.DeleteFolder Task.Path & "\bin"
    End If
    If FSo.FolderExists(Task.Path & "\obj") Then 
      Log = Log & Folder.Name & "\" & Task.Name & "\obj" & vbCrLf 
      FSo.DeleteFolder Task.Path & "\obj"
    End If
  Next
  
End Sub