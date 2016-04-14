@ModelType KnightExchange.user
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>user</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.user_lname)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.user_lname)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.user_fname)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.user_fname)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.user_email)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.user_email)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.user_permission)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.user_permission)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
