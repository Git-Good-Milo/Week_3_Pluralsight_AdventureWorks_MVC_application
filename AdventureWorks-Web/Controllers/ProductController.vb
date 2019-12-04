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
    End Class
End Namespace