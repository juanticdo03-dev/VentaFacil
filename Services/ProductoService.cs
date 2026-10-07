public bool ValidarProducto(Producto producto) {
	if (string.IsNullOrWhiteSpace(producto.Nombre)) return false;
	if (producto.Precio <= 0) return false;
	return true;
}
