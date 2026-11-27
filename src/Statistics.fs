module Statistics
open Models

let passMark = 50.0

let studentAverage (student: Student) : float =
    match student.Grades with
    | [] -> 0.0
    | grades -> List.average grades

let isPassing (student: Student) : bool =
    studentAverage student >= passMark

let classAverage (students: Student list) : float =
    match students with
    | [] -> 0.0
    | _ -> students |> List.map studentAverage |> List.average

let passCount (students: Student list) : int =
    students |> List.filter isPassing |> List.length

let failCount (students: Student list) : int =
    students |> List.filter (isPassing >> not) |> List.length

let passRate (students: Student list) : float =
    match students with
    | [] -> 0.0
    | _ -> float (passCount students) / float (List.length students) * 100.0

let failRate (students: Student list) : float =
    match students with
    | [] -> 0.0
    | _ -> 100.0 - passRate students
