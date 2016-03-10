@ModelType user
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>user</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.user_fname)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.user_fname)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.user_lname)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.user_lname)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.user_email)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.user_email)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.user_phone)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.user_phone)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.user_level)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.user_level)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.user_pswd)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.user_pswd)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.auth_level)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.auth_level)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.auth_desc)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.auth_desc)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.user_number }) |
    @Html.ActionLink("Back to List", "Index")
</p>
