Imports Microsoft.EntityFrameworkCore

Public Class StudentContext
    Inherits DbContext

    Public Property Students As DbSet(Of Student)

    Protected Overrides Sub OnConfiguring(optionsBuilder As DbContextOptionsBuilder)
        optionsBuilder.UseSqlServer(
            "Server=(localdb)\MSSQLLocalDB;Database=StudentDatabase;Trusted_Connection=True;TrustServerCertificate=True")
    End Sub
End Class

