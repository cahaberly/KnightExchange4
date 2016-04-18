Imports System.Data.Entity
Imports System.Net


Namespace Controllers
    Public Class productsController
        Inherits System.Web.Mvc.Controller

        Private db As New KnightExchangeDBEntities1

        ' GET: products
        Function Index() As ActionResult
            Dim products = db.products.Include(Function(p) p.product_info).Include(Function(p) p.user)
            Return View(products.ToList())
        End Function

        ' GET: products/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim product As product = db.products.Find(id)
            If IsNothing(product) Then
                Return HttpNotFound()
            End If
            Return View(product)
        End Function

        ' GET: products/Create
        Function Create() As ActionResult
            ViewBag.productinfo_id = New SelectList(db.product_info, "productinfo_id", "product_name")
            ViewBag.user_id = New SelectList(db.users, "user_id", "user_lname")
            Return View()
        End Function

        ' POST: products/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="product_id,user_id,productinfo_id")> ByVal product As product) As ActionResult
            If ModelState.IsValid Then
                db.products.Add(product)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.productinfo_id = New SelectList(db.product_info, "productinfo_id", "product_name", product.productinfo_id)
            ViewBag.user_id = New SelectList(db.users, "user_id", "user_lname", product.user_id)
            Return View(product)
        End Function

        ' GET: products/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim product As product = db.products.Find(id)
            If IsNothing(product) Then
                Return HttpNotFound()
            End If
            ViewBag.productinfo_id = New SelectList(db.product_info, "productinfo_id", "product_name", product.productinfo_id)
            ViewBag.user_id = New SelectList(db.users, "user_id", "user_lname", product.user_id)
            Return View(product)
        End Function

        ' POST: products/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="product_id,user_id,productinfo_id")> ByVal product As product) As ActionResult
            If ModelState.IsValid Then
                db.Entry(product).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.productinfo_id = New SelectList(db.product_info, "productinfo_id", "product_name", product.productinfo_id)
            ViewBag.user_id = New SelectList(db.users, "user_id", "user_lname", product.user_id)
            Return View(product)
        End Function

        ' GET: products/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim product As product = db.products.Find(id)
            If IsNothing(product) Then
                Return HttpNotFound()
            End If
            Return View(product)
        End Function

        ' POST: products/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim product As product = db.products.Find(id)
            db.products.Remove(product)
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
