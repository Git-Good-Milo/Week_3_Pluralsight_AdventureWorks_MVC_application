@ModelType AdventureWorks.ViewModelLayer.ProductViewModel1

@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    ViewBag.Title = "Product Detail"
End Code

<div class="row">
    <div class="col-sm-3">Product ID</div>
    <div class="col-sm-9">@Model.Entity.ProductID</div>
</div>
<div class="row">
    <div class="col-sm-3">Product Name</div>
    <div class="col-sm-9">@Model.Entity.Name</div>
</div>
<div class="row">
    <div class="col-sm-3">Product Number</div>
    <div class="col-sm-9">@Model.Entity.ProductNumber</div>
</div>
<div class="row">
    <div class="col-sm-3">Product Number</div>
    <div class="col-sm-9">@Model.Entity.Color</div>
</div>
<div class="row">
    <div class="col-sm-3">Product Number</div>
    <div class="col-sm-9">@Model.Entity.Size</div>
</div>
<div class="row">
    <div class="col-sm-3">Product Number</div>
    <div class="col-sm-9">@Model.Entity.Weight</div>
</div>
<div class="row">
    <div class="col-sm-3">Standard Cost</div>
    <div class="col-sm-9">@Model.Entity.StandardCost</div>
</div>
<div class="row">
    <div class="col-sm-3">List Price</div>
    <div class="col-sm-9">@Model.Entity.ListPrice</div>
</div>
<div class="row">
    <div class="col-sm-3">Sell Start Date</div>
    <div class="col-sm-9">@Model.Entity.SellStartDate</div>
</div>
<div class="row">
    <div class="col-sm-3">Sell End Date</div>
    <div class="col-sm-9">@Model.Entity.SellEndDate</div>
</div>
