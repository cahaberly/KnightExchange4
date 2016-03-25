Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace KnightExchange
    Public Class servicesController
        Inherits System.Web.Mvc.Controller

        Private db As New KnightExchangeDBEntities

        ' GET: /services/
        Function Index() As ActionResult
            Dim services = db.services.Include(Function(s) s.user)
            Return View(services.ToList())
        End Function

        ' GET: /services/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim service As service = db.services.Find(id)
            If IsNothing(service) Then
                Return HttpNotFound()
            End If
            Return View(service)
        End Function

        ' GET: /services/Create
        Function Create() As ActionResult
            ViewBag.user_number = New SelectList(db.users, "user_number", "user_fname")
            Return View()
        End Function

        ' POST: /services/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "service_number,user_number,service_name,service_description,trade_for")> ByVal service As service) As ActionResult
            If ModelState.IsValid Then
                db.services.Add(service)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            ViewBag.user_number = New SelectList(db.users, "user_number", "user_fname", service.user_number)
            Return View(service)
        End Function

        ' GET: /services/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim service As service = db.services.Find(id)
            If IsNothing(service) Then
                Return HttpNotFound()
            End If
            ViewBag.user_number = New SelectList(db.users, "user_number", "user_fname", service.user_number)
            Return View(service)
        End Function

        ' POST: /services/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "service_number,user_number,service_name,service_description,trade_for")> ByVal service As service) As ActionResult
            If ModelState.IsValid Then
                db.Entry(service).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.user_number = New SelectList(db.users, "user_number", "user_fname", service.user_number)
            Return View(service)
        End Function

        ' GET: /services/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim service As service = db.services.Find(id)
            If IsNothing(service) Then
                Return HttpNotFound()
            End If
            Return View(service)
        End Function

        ' POST: /services/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim service As service = db.services.Find(id)
            db.services.Remove(service)
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
