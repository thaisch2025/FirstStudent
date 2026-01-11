Imports System
Imports System.Linq

Module Program
    Sub Main(args As String())
        Using db As New StudentContext()

            ' Cria o banco e as tabelas com base nas classes (Code-First)
            db.Database.EnsureCreated()

            ' Adiciona 1 aluno (só se ainda não existir)
            If Not db.Students.Any() Then
                db.Students.Add(New Student With {.Name = "Maria Silva"})
                db.SaveChanges()
            End If

            Console.WriteLine("Done!")
            Console.WriteLine("Total students: " & db.Students.Count())

        End Using

        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module

