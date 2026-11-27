module StudentGrades.Models

/// student data type
type Student =
    { Id: int
      Name: string
      Grades: float list }

type Role =
    | Admin   // full control over db and grade editing
    | Viewer  // read-only access 
