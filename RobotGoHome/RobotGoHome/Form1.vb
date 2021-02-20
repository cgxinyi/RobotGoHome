Public Class form_robot
    'to identify the rotation of robot image
    'to right 90 = 1 = to left 270
    'to right 180 = 2 = to left 180
    'to right 270 = 3 = to left 90
    'no rotation = 0
    Dim robotPosition As Integer = 0

    ' set value 5 to trigger while loop for robot
    Dim heightRoboValid As Integer = 5
    Dim widthRoboValid As Integer = 5
    Dim topRobo As Integer
    Dim widthRobo As Integer
    ' set value 5 to trigger while loop for home
    Dim heightHomeValid As Integer = 5
    Dim widthHomeValid As Integer = 5
    Dim topHome As Integer
    Dim widthHome As Integer
    Private Sub RobotGOHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' randomize home and robot position
        Dim random As New Random()

        ' value of 300 is to set the image within the border and not located at (300,300) or more
        While ((heightRoboValid Mod 10) <> 0 Or heightRoboValid > 300)
            heightRoboValid = random.Next((panel_robo.Height - pic_robot.Height))
            Console.WriteLine((heightHomeValid Mod 10).ToString + "heightrobovalid")

        End While

        If ((heightRoboValid Mod 10) = 0 And heightRoboValid < 300) Then
            topRobo = heightRoboValid
            Console.WriteLine(topRobo)
        End If

        While ((widthRoboValid Mod 10) <> 0 Or widthRoboValid > 300)
            widthRoboValid = random.Next((panel_robo.Width - pic_robot.Width))
            Console.WriteLine((widthRoboValid Mod 10).ToString + "widthrobovalid")

        End While

        If ((widthRoboValid Mod 10) = 0 And widthRoboValid < 300) Then
            widthRobo = widthRoboValid
            Console.WriteLine(widthRobo)
        End If

        While ((heightHomeValid Mod 10) <> 0 Or heightHomeValid > 300)
            heightHomeValid = random.Next((panel_robo.Height - pic_robot.Height))
            Console.WriteLine((heightHomeValid Mod 10).ToString + "heighthomevalid")

        End While

        If ((heightRoboValid Mod 10) = 0 And heightHomeValid < 300) Then
            topHome = heightHomeValid
            Console.WriteLine(topHome)
        End If

        While ((widthHomeValid Mod 10) <> 0 Or widthHomeValid > 300)
            Console.WriteLine((widthHomeValid Mod 10).ToString + "widthhomevalid")
            widthHomeValid = random.Next((panel_robo.Width - pic_robot.Width))

        End While

        If ((widthHomeValid Mod 10) = 0 And widthHomeValid < 300) Then
            widthHome = widthHomeValid
            Console.WriteLine(widthHome)
        End If


        pic_robot.Location = New Point(widthRobo, topRobo)
        pic_home.Location = New Point(widthHome, topHome)

        'show commands info
        label_info.Text = "Commands: " & Environment.NewLine &
            "R : rotate to right 90 degree" & Environment.NewLine &
            "L : rotate to left 90 degree" & Environment.NewLine &
            "B : move backward" & Environment.NewLine &
            "F : move forward" & Environment.NewLine & Environment.NewLine &
            Environment.NewLine & "Tips: " & Environment.NewLine &
            "Use comma to input multiple " & Environment.NewLine &
            "command, follow with number to" & Environment.NewLine &
            "indicate the times" & Environment.NewLine & "Example: R1,F2" &
            Environment.NewLine & "( R1: turn right 90 degree once ) &" &
            Environment.NewLine & "( F2: forward 2 steps )" &
            Environment.NewLine & Environment.NewLine &
            "How to Win:" & Environment.NewLine &
            "Robot need to be send home at" & Environment.NewLine &
            "stacking on top or left of home"

        ' Successfully send robot back home
        If (topRobo = topHome And widthRobo = widthHome) Then
            MessageBox.Show("Thank you for sending robot back home!!")
        End If
    End Sub


    Private Sub Btn_userInput_Click(sender As Object, e As EventArgs) Handles btn_userInput.Click
        'read user input
        Dim userInput As String = txt_userInput.Text

        'split user input via comma
        Dim commands As String() = userInput.Split(New Char() {","c})

        'declare rotation image bitmap
        Dim rotateRobot As Image = New Bitmap(pic_robot.Image)

        'declare command and its' length
        Dim command As String = ""
        Dim commandLength As Integer = 1
        'loop And display
        For Each command In commands
            'read command input and command length
            commandLength = command.Length - 1

            'check if input is empty and output message for user 
            If (command = "") Then
                MessageBox.Show("Please enter command to send robot go home.")

                'read command for rotate to right and action
            ElseIf (command.Contains("R") And IsNumeric(command.Substring(1, commandLength))) Then
                Dim rotateTimeStr As String = command.Substring(1, commandLength)
                Dim rotateTime As Integer = Integer.Parse(rotateTimeStr)
                'rotate as time
                If ((rotateTime Mod 4) = 1) Then
                    rotateRobot.RotateFlip(RotateFlipType.Rotate90FlipNone)
                    pic_robot.Image = rotateRobot
                    robotPosition += 1
                    Console.WriteLine("Flip 90r success")
                ElseIf ((rotateTime Mod 4) = 2) Then
                    rotateRobot.RotateFlip(RotateFlipType.Rotate180FlipNone)
                    pic_robot.Image = rotateRobot
                    robotPosition += 2
                    Console.WriteLine("Flip 180r success")
                ElseIf ((rotateTime Mod 4) = 3) Then
                    rotateRobot.RotateFlip(RotateFlipType.Rotate270FlipNone)
                    pic_robot.Image = rotateRobot
                    robotPosition += 3
                    Console.WriteLine("Flip 270r success")
                ElseIf ((rotateTime Mod 4) = 0) Then
                    robotPosition += 0
                    Console.WriteLine("Flipping 360r")
                End If




                'read command for rotate to left and action
            ElseIf (command.Contains("L") And IsNumeric(command.Substring(1, commandLength))) Then
                Dim rotateTimeStr As String = command.Substring(1, commandLength)
                Dim rotateTime As Integer = Integer.Parse(rotateTimeStr)
                'rotate as time
                If ((rotateTime Mod 4) = 1) Then
                    rotateRobot.RotateFlip(RotateFlipType.Rotate270FlipNone)
                    pic_robot.Image = rotateRobot
                    robotPosition += 3
                    Console.WriteLine("Flip 270l success")
                ElseIf ((rotateTime Mod 4) = 2) Then
                    rotateRobot.RotateFlip(RotateFlipType.Rotate180FlipNone)
                    pic_robot.Image = rotateRobot
                    robotPosition += 2
                    Console.WriteLine("Flip 180l success")
                ElseIf ((rotateTime Mod 4) = 3) Then
                    rotateRobot.RotateFlip(RotateFlipType.Rotate90FlipNone)
                    pic_robot.Image = rotateRobot
                    robotPosition += 1
                    Console.WriteLine("Flip 90l success")
                ElseIf ((rotateTime Mod 4) = 0) Then
                    robotPosition += 0
                    Console.WriteLine("Flipping 360l")
                End If



                'read command input forward and action
            ElseIf (command.Contains("F") And IsNumeric(command.Substring(1, commandLength))) Then
                Dim stepCount As String = command.Substring(1, commandLength)
                'times that user command to move
                Dim stepCountInt As Integer = Integer.Parse(stepCount)
                'multiply 10 to move picture position
                Dim stepMove As Integer = stepCountInt * 10
                Console.WriteLine("stepcount" + stepCountInt.ToString + "stepmove" + stepMove.ToString)
                'read imageposition via robotPosition if it is rotated or not and its location via topRobo&widthRobo
                'move position by adding value to its original position
                If ((robotPosition Mod 4) = 0) Then
                    'update new position
                    Console.WriteLine("Robo position" + topRobo.ToString + "," + widthRobo.ToString)
                    topRobo += stepMove
                    If (topRobo > 0 And topRobo < 300) Then
                        pic_robot.Location = New Point(widthRobo, topRobo)
                        Console.WriteLine("After changing" + (pic_robot.Location).ToString)
                        Console.WriteLine("0move")
                    Else
                        MessageBox.Show("Oh no, there is no available space to continue, 
                        please adjust your commands for robot to move within the space")

                    End If

                ElseIf ((robotPosition Mod 4) = 1) Then
                    'update new position
                    widthRobo -= stepMove
                    If (widthRobo > 0 And widthRobo < 300) Then
                        pic_robot.Location = New Point(widthRobo, topRobo)
                        Console.WriteLine("1movef")
                    Else
                        MessageBox.Show("Oh no, there is no available space to continue, 
                        please adjust your commands for robot to move within the space")
                    End If

                ElseIf ((robotPosition Mod 4) = 2) Then
                    'update new position
                    topRobo -= stepMove
                    If (topRobo > 0 And topRobo < 300) Then
                        pic_robot.Location = New Point(widthRobo, topRobo)
                        Console.WriteLine("2movef")
                    Else
                        MessageBox.Show("Oh no, there is no available space to continue, 
                        please adjust your commands for robot to move within the space")
                    End If

                ElseIf ((robotPosition Mod 4) = 3) Then
                    'update new position
                    widthRobo += stepMove
                    If (widthRobo > 0 And widthRobo < 300) Then
                        pic_robot.Location = New Point(widthRobo, topRobo)
                        Console.WriteLine("3movef")
                    Else
                        MessageBox.Show("Oh no, there is no available space to continue, 
                        please adjust your commands for robot to move within the space")
                    End If

                End If



                'read command input backward and action
            ElseIf (command.Contains("B") And IsNumeric(command.Substring(1, commandLength))) Then
                Dim stepCount As String = command.Substring(1, commandLength)
                'times that user command to move
                Dim stepCountInt As Integer = Integer.Parse(stepCount)
                'multiply 10 to move picture position
                Dim stepMove As Integer = stepCountInt * 10
                Console.WriteLine("stepcount" + stepCountInt.ToString + "stepmove" + stepMove.ToString)
                'read imageposition via robotPosition if it is rotated or not and its location via topRobo&widthRobo
                'move position by adding value to its original position
                If ((robotPosition Mod 4) = 0) Then
                    'update new position
                    Console.WriteLine("Robo position" + topRobo.ToString + "," + widthRobo.ToString)
                    topRobo -= stepMove
                    If (topRobo > 0 And topRobo < 300) Then
                        pic_robot.Location = New Point(widthRobo, topRobo)
                        Console.WriteLine("After changing" + (pic_robot.Location).ToString)
                        Console.WriteLine("0move")
                    Else
                        MessageBox.Show("Oh no, there is no available space to continue, 
                        please adjust your commands for robot to move within the space")
                    End If

                ElseIf ((robotPosition Mod 4) = 1) Then
                    'update new position
                    widthRobo += stepMove
                    If (widthRobo > 0 And widthRobo < 300) Then
                        pic_robot.Location = New Point(widthRobo, topRobo)
                        Console.WriteLine("3moveb")
                    Else
                        MessageBox.Show("Oh no, there is no available space to continue, 
                        please adjust your commands for robot to move within the space")
                    End If

                ElseIf ((robotPosition Mod 4) = 2) Then
                    'update new position
                    topRobo += stepMove
                    If (topRobo > 0 And topRobo < 300) Then
                        pic_robot.Location = New Point(widthRobo, topRobo)
                        Console.WriteLine("2moveb")
                    Else
                        MessageBox.Show("Oh no, there is no available space to continue, 
                        please adjust your commands for robot to move within the space")
                    End If
                ElseIf ((robotPosition Mod 4) = 3) Then
                    'update new position
                    widthRobo -= stepMove
                    If (widthRobo > 0 And widthRobo < 300) Then
                        pic_robot.Location = New Point(widthRobo, topRobo)
                        Console.WriteLine("1moveb")
                    Else
                        MessageBox.Show("Oh no, there is no available space to continue, 
                        please adjust your commands for robot to move within the space")
                    End If
                End If

            Else
                MessageBox.Show（"Please enter the correct format of commands eg.F1,R1,L1,B2"）
            End If

            If (topRobo = topHome And widthRobo = widthHome) Then
                MessageBox.Show("Thank you for sending robot back home!!")
            End If
        Next



    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        label_info.Text = "Commands: " & Environment.NewLine & "R : rotate to right 90 degree" & Environment.NewLine & "L : rotate to left 90 degree" & Environment.NewLine & "B : move backward" & Environment.NewLine & "F : move forward"
    End Sub


End Class
