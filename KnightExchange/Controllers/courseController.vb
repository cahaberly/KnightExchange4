Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace KnightExchange
    Public Class courseController
        Inherits System.Web.Mvc.Controller

        Private db As New KnightExchangeDBEntities

        ' GET: /course/
        Function Index() As ActionResult
            Return View(db.courses.ToList())
        End Function

        ' GET: /course/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim cours As cours = db.courses.Find(id)
            If IsNothing(cours) Then
                Return HttpNotFound()
            End If
            Return View(cours)
        End Function

        ' GET: /course/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: /course/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "crn,course_id,course_name,instructor_lname")> ByVal cours As cours) As ActionResult
            If ModelState.IsValid Then
                db.courses.Add(cours)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            Return View(cours)
        End Function

        ' GET: /course/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim cours As cours = db.courses.Find(id)
            If IsNothing(cours) Then
                Return HttpNotFound()
            End If
            Return View(cours)
        End Function

        ' POST: /course/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "crn,course_id,course_name,instructor_lname")> ByVal cours As cours) As ActionResult
            If ModelState.IsValid Then
                db.Entry(cours).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(cours)
        End Function

        ' GET: /course/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim cours As cours = db.courses.Find(id)
            If IsNothing(cours) Then
                Return HttpNotFound()
            End If
            Return View(cours)
        End Function

        ' POST: /course/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim cours As cours = db.courses.Find(id)
            db.courses.Remove(cours)
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
