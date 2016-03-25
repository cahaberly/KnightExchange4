Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace KnightExchange
    Public Class suppliesController
        Inherits System.Web.Mvc.Controller

        Private db As New KnightExchangeDBEntities

        ' GET: /supplies/
        Function Index() As ActionResult
            Dim supplies = db.supplies.Include(Function(s) s.user)
            Return View(supplies.ToList())
        End Function

        ' GET: /supplies/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim supply As supply = db.supplies.Find(id)
            If IsNothing(supply) Then
                Return HttpNotFound()
            End If
            Return View(supply)
        End Function

        ' GET: /supplies/Create
        Function Create() As ActionResult
            ViewBag.user_number = New SelectList(db.users, "user_number", "user_fname")
            Return View()
        End Function

        ' POST: /supplies/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "supply_id,user_number,crn,make,model,description")> ByVal supply As supply) As ActionResult
            If ModelState.IsValid Then
                db.supplies.Add(supply)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            ViewBag.user_number = New SelectList(db.users, "user_number", "user_fname", supply.user_number)
            Return View(supply)
        End Function

        ' GET: /supplies/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim supply As supply = db.supplies.Find(id)
            If IsNothing(supply) Then
                Return HttpNotFound()
            End If
            ViewBag.user_number = New SelectList(db.users, "user_number", "user_fname", supply.user_number)
            Return View(supply)
        End Function

        ' POST: /supplies/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "supply_id,user_number,crn,make,model,description")> ByVal supply As supply) As ActionResult
            If ModelState.IsValid Then
                db.Entry(supply).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.user_number = New SelectList(db.users, "user_number", "user_fname", supply.user_number)
            Return View(supply)
        End Function

        ' GET: /supplies/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim supply As supply = db.supplies.Find(id)
            If IsNothing(supply) Then
                Return HttpNotFound()
            End If
            Return View(supply)
        End Function

        ' POST: /supplies/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim supply As supply = db.supplies.Find(id)
            db.supplies.Remove(supply)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
