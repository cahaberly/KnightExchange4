'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Partial Public Class user

    <Key>
    Public Property user_id As Integer

    <Required>
    <Display(Name:="Last Name")>
    Public Property user_lname As String

    <Display(Name:="First Name")>
    Public Property user_fname As String

    <Display(Name:="Full Name")>
    <NotMapped>
    Public Property fullName As String
        Get
            Return user_lname & ", " & user_fname
        End Get
        Set(value As String)

        End Set
    End Property

    <Required>
    <Display(Name:="Email Address")>
    Public Property user_email As String

    <Required>
    <Display(Name:="Permission Level")>
    Public Property user_permission As String

    Public Overridable Property books As ICollection(Of book) = New HashSet(Of book)
    Public Overridable Property products As ICollection(Of product) = New HashSet(Of product)

End Class
