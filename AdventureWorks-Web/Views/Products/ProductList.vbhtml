@ModelType AdventureWorks.ViewModelLayer.ProductViewModel1

@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    ViewBag.Title = "Products"
End Code

<table class="table table-bordered table-striped">
    <thead>
        <tr>
            <th>Product ID</th>
            <th>Product Name</th>
            <th>Product Number</th>
            <th>Colour</th>
            <th>Size</th>
            <th>Cost</th>
            <th>Price</th>
        </tr>
    </thead>

    @For Each product In Model.Products
        @<tbody>
             <tr>
                 <td>@product.ProductID</td>
                 <td>
                     @Html.ActionLink(product.Name, "ProductDetail",
                           New With {.id = product.ProductID})
                 </td>
                 <td>@product.Name</td>
                 <td>@product.ProductNumber</td>
                 <td>@product.Color</td>
                 <td>@product.Size</td>
                 <td>@product.StandardCost</td>
                 <td>@product.ListPrice</td>
             </tr>
        </tbody>

    Next
</table>