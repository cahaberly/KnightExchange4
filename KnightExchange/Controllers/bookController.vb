Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace KnightExchange
    Public Class bookController
        Inherits System.Web.Mvc.Controller

        Private db As New KnightExchangeDBEntities

        ' GET: /book/
        Function Index() As ActionResult
            Dim books = db.books.Include(Function(b) b.cours).Include(Function(b) b.user)
            Return View(books.ToList())
        End Function

        ' GET: /book/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim book As book = db.books.Find(id)
            If IsNothing(book) Then
                Return HttpNotFound()
            End If
            Return View(book)
        End Function

        ' GET: /book/Create
        Function Create() As ActionResult
            ViewBag.crn = New SelectList(db.courses, "crn", "course_id")
            ViewBag.user_number = New SelectList(db.users, "user_number", "user_fname")
            Return View()
        End Function

        ' POST: /book/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "book_id,user_number,crn,isbn,title,edition,author")> ByVal book As book) As ActionResult
            If ModelState.IsValid Then
                db.books.Add(book)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            ViewBag.crn = New SelectList(db.courses, "crn", "course_id", book.crn)
            ViewBag.user_number = New SelectList(db.users, "user_number", "user_fname", book.user_number)
            Return View(book)
        End Function

        ' GET: /book/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim book As book = db.books.Find(id)
            If IsNothing(book) Then
                Return HttpNotFound()
            End If
            ViewBag.crn = New SelectList(db.courses, "crn", "course_id", book.crn)
            ViewBag.user_number = New SelectList(db.users, "user_number", "user_fname", book.user_number)
            Return View(book)
        End Function

        ' POST: /book/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "book_id,user_number,crn,isbn,title,edition,author")> ByVal book As book) As ActionResult
            If ModelState.IsValid Then
                db.Entry(book).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.crn = New SelectList(db.courses, "crn", "course_id", book.crn)
            ViewBag.user_number = New SelectList(db.users, "user_number", "user_fname", book.user_number)
            Return View(book)
        End Function

        ' GET: /book/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim book As book = db.books.Find(id)
            If IsNothing(book) Then
                Return HttpNotFound()
            End If
            Return View(book)
        End Function

        ' POST: /book/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim book As book = db.books.Find(id)
            db.books.Remove(book)
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
