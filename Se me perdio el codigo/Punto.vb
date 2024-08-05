Public Class Punto
    Private _nombre As String
    Private _apellido As String
    Private _cedula As String
    Private _fecha As String
    Private _nombre_producto As String
    Private _precio_producto As String

    'constructor
    Public Sub New(ByVal nombre As String, ByVal apellido As String, ByVal cedula As String, ByVal fecha As String, ByVal nombre_producto As String, ByVal precio_producto As String)
        Me._nombre = nombre
        Me._apellido = apellido
        Me._cedula = cedula
        Me._fecha = fecha
        Me._nombre_producto = nombre_producto
        Me._precio_producto = precio_producto
    End Sub

    'gets para obetener las propiedades de la clase
    Property Nombre As String
        Get
            Return Me._nombre
        End Get
        Set(value As String)
            Me._nombre = value
        End Set
    End Property

    Property Apellido As String
        Get
            Return Me._apellido
        End Get
        Set(value As String)
            Me._apellido = value
        End Set
    End Property

    Property Cedula As String
        Get
            Return Me._cedula
        End Get
        Set(value As String)
            Me._cedula = value
        End Set
    End Property

    Property Fecha As String
        Get
            Return Me._fecha
        End Get
        Set(value As String)
            Me._fecha = value
        End Set
    End Property

    Property NombreProducto As String
        Get
            Return Me._nombre_producto
        End Get
        Set(value As String)
            Me._nombre_producto = value
        End Set
    End Property

    Property PrecioItem As String
        Get
            Return Me._precio_producto
        End Get
        Set(value As String)
            Me._precio_producto = value
        End Set
    End Property
End Class
