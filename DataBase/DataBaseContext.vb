Imports System.Numerics
Imports System.Reflection.Emit
Imports System.Windows.Media.Media3D
Imports Microsoft.EntityFrameworkCore

Public Class DataBaseContext
    Inherits DbContext
    Public Property teeth_status As DbSet(Of TeethStatus)
    'Public Property person As DbSet(Of Person)
    'Public Property phone As DbSet(Of Phone)
    'Public Property doctor As DbSet(Of Doctor)
    'Public Property dentalTechnician As DbSet(Of DentalTechnician)
    'Public Property employee As DbSet(Of Employee)
    'Public Property clinic As DbSet(Of Clinic)
    'Public Property request As DbSet(Of Request)
    'Public Property billing As DbSet(Of Billing)
    'Public Property attendance As DbSet(Of Attendance)
    'Public Property material As DbSet(Of Material)
    'Public Property storedMaterial As DbSet(Of StoredMaterial)
    'Public Property storekeeper As DbSet(Of Storekeeper)
    'Public Property usres As DbSet(Of Usres)
    'Public Property center As DbSet(Of Center)
    'Public Property express As DbSet(Of Express)
    'Public Property students As DbSet(Of Student)
    'Public Property aldorats As DbSet(Of Aldorat)

    'Protected Overrides Sub OnModelCreating(ByVal modelBuilder As ModelBuilder)
    '    modelBuilder.Entity(Of Person)().HasOne(Function(p) p.Center).WithMany(Function(c) c.Persons).HasForeignKey(Function(p) p.CenterID)
    '    modelBuilder.Entity(Of Doctor)().HasMany(Function(d) d.Requests).WithMany(Function(r) r.Doctors).UsingEntity(Function(j) j.ToTable('DoctorRequests'))
    '    modelBuilder.Entity(Of Request)().HasKey(Function(w) New With {w.EmployeeID, w.ClinicID
    '    })
    '    modelBuilder.Entity(Of Request)().HasOne(Function(w) w.Employee).WithMany(Function(e) e.Requests).HasForeignKey(Function(w) w.EmployeeID)
    '    modelBuilder.Entity(Of Request)().HasOne(Function(w) w.Clinic).WithMany().HasForeignKey(Function(w) w.ClinicID)
    '    modelBuilder.Entity(Of Attendance)().HasOne(Function(a) a.Person).WithMany().HasForeignKey(Function(a) a.PersonID)
    '    modelBuilder.Entity(Of StoredMaterial)().HasKey(Function(sm) New With {sm.MaterialID, sm.StorekeeperID
    '    })
    '    modelBuilder.Entity(Of StoredMaterial)().HasOne(Function(sm) sm.Material).WithMany(Function(m) m.StoredMaterials).HasForeignKey(Function(sm) sm.MaterialID)
    '    modelBuilder.Entity(Of StoredMaterial)().HasOne(Function(sm) sm.Storekeeper).WithMany().HasForeignKey(Function(sm) sm.StorekeeperID)
    'End Sub

    Protected Overrides Sub OnConfiguring(ByVal optionsBuilder As DbContextOptionsBuilder)
        optionsBuilder.UseMySQL("server=localhost;database=managingadentalclinic;user=root;password=")
    End Sub
End Class
