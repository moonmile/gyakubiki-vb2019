@ModelType web453.MyModel
@Code
    ViewData("Title") = "Post"
End Code

<h2>結果</h2>
<table border="0">
    <tr>
        <td>ID</td>
        <td>@Model.ID</td>
    </tr>
    <tr>
        <td>タイトル</td>
        <td>@Model.Title</td>
    </tr>
    <tr>
        <td>価格</td>
        <td>@Model.Price</td>
    </tr>
</table>


