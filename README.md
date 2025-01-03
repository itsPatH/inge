# Product Inventory API

Una API RESTful para gestionar productos en un inventario. Permite crear, leer, actualizar y eliminar productos, así como calcular el total a pagar por un producto con base en descuentos aplicables.

## Funcionalidades

- **Crear productos** con información como nombre, precio, stock y fecha de creación.
- **Obtener productos**: consultar todos los productos o buscar un producto por ID.
- **Actualizar productos**: modificar detalles de un producto existente.
- **Eliminar productos**: eliminar un producto del inventario (con restricciones).
- **Calcular precio total**: obtener el precio total de un producto considerando descuentos por cantidad o precio.

## Reglas Especiales

- Si el precio de un producto es mayor a **$1000**, el stock debe ser al menos **10**.
- No se puede eliminar un producto que tenga stock disponible.
- Descuentos aplicados de acuerdo a la cantidad solicitada:
  - Si la cantidad es mayor a **50**, se aplica un **descuento del 10%**.
  - Si el precio del producto es mayor a **$500**, se aplica un **descuento adicional del 5%**.

## Endpoints

### 1. **GET /api/productos**

Obtiene la lista de todos los productos del inventario.

**Respuesta exitosa:**
- **Código 200 OK**
- **Cuerpo**: Lista de productos en formato JSON.

```json
[
  {
    "id": 1,
    "nombre": "Producto A",
    "precio": 1200.00,
    "stock": 10,
    "imagen": "base64imagen",
    "fechaCreacion": "2025-01-01T00:00:00"
  },
  {
    "id": 2,
    "nombre": "Producto B",
    "precio": 500.00,
    "stock": 20,
    "imagen": "base64imagen",
    "fechaCreacion": "2025-01-02T00:00:00"
  }
]
