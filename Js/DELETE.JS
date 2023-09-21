document.addEventListener("DOMContentLoaded", function () {
    const deleteButton = document.getElementById("deleteButton");
    const ProductoID = document.getElementById("ProductoID");
    const resultDiv = document.getElementById("result");

    deleteButton.addEventListener("click", function() {
        const id = ProductoID.value;


        // URL del servicio para eliminar el producto por ID
        const apiUrl = `https://localhost:44353/api/productos/${id}`;

        // Opciones para la solicitud DELETE

        // Realizar la solicitud DELETE
        fetch(apiUrl, {
            method: 'DELETE',
            headers: {
                'Content-Type': 'application/json', // Ajusta el tipo de contenido según sea necesario
                // Otras cabeceras si es necesario
            }
        })
            .then(response => {
                if (response.ok) {
                   console.log("Producto Eliminado con exito");
                } else {
                    resultDiv.textContent = "No se pudo eliminar el producto. Verifique el ID.";
                }
            })
            .catch(error => {
                resultDiv.textContent = `Error en la solicitud DELETE: ${error}`;
            });
    });
});
