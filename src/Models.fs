module StudentGrades.Models

/// One student. Records are immutable: to "change" a student we build a new record.
type Student =
    { Id: int
      Name: string
      Grades: float list }

/// The two user roles required by the project.
type Role =
    | Admin   // full control over the database and grade editing
    | Viewer  // read-only access to grades and reports
