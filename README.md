# DbContext y Exportación a PDF en ASP.NET Core

## DbContext

El archivo `ContactoContext.cs` define un DbContext utilizando Entity Framework Core para interactuar con la base de datos que contiene los contactos.

## Exportación a PDF

En la vista `Index.cshtml`, se utiliza DataTables para mostrar los contactos en una tabla interactiva. Se implementa la funcionalidad de exportación a PDF mediante la extensión `pdfHtml5` de DataTables.

### Implementación

- Se incluye la librería jsPDF para generar el archivo PDF en el navegador.
- Se configuran los botones de exportación en el script JavaScript de la vista para permitir al usuario exportar la tabla a un archivo PDF.
- Se definen opciones como el nombre del archivo y las columnas a incluir en el PDF.

## Resumen

- **DbContext**: Maneja la conexión y las operaciones con la base de datos de contactos.
- **Exportación a PDF**: Permite al usuario exportar los datos de la tabla de contactos a un archivo PDF directamente desde la vista utilizando DataTables y jsPDF.
