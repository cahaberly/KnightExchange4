Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports KnightExchange

Namespace Controllers
    Public Class product_infoController
        Inherits System.Web.Mvc.Controller

        Private db As New KnightExchangeDBEntities

        ' GET: product_info
        Function Index() As ActionResult
            Return View(db.product_info.ToList())
        End Function

        ' GET: product_info/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim product_info As product_info = db.product_info.Find(id)
            If IsNothing(product_info) Then
                Return HttpNotFound()
            End If
            Return View(product_info)
        End Function

        ' GET: product_info/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: product_info/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="productinfo_id,product_name,product_description")> ByVal product_info As product_info) As ActionResult
            If ModelState.IsValid Then
                db.product_info.Add(product_info)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(product_info)
        End Function

        ' GET: product_info/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim product_info As product_info = db.product_info.Find(id)
            If IsNothing(product_info) Then
                Return HttpNotFound()
            End If
            Return View(product_info)
        End Function

        ' POST: product_info/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="productinfo_id,product_name,product_description")> ByVal product_info As product_info) As ActionResult
            If ModelState.IsValid Then
                db.Entry(product_info).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(product_info)
        End Function

        ' GET: product_info/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim product_info As product_info = db.product_info.Find(id)
            If IsNothing(product_info) Then
                Return HttpNotFound()
            End If
            Return View(product_info)
        End Function

        ' POST: product_info/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim product_info As product_info = db.product_info.Find(id)
            db.product_info.Remove(product_info)
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
