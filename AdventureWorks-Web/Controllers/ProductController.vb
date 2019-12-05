Imports AdventureWorks.ViewModelLayer

Namespace Controllers
    Public Class ProductsController
        Inherits Controller

        ' GET products

        Function ProductList() As ActionResult
            Dim vm As New ProductViewModel1

            vm.LoadProducts(Server.MapPath("/"))

            Return View(vm)
        End Function

        Function ProductDetail(ByVal id As Integer) As ActionResult
            Dim vm As New ProductViewModel1

            vm.LoadProduct(id, Server.MapPath("/"))

            Return View(vm)
        End Function
    End Class
End Namespace