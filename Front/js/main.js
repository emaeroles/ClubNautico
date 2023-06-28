
document.getElementById('get').addEventListener('click', async () => {
    let data = await getSocioById();
    mostrarSocio(data);
});
document.getElementById('getAll').addEventListener('click', async () => {
    let data = await getAllSocios();
    mostrarSocios(data);
});
document.getElementById('post').addEventListener('click', async () => {
    let data = await postSocio();
    mostrarSocio(data);
});
document.getElementById('put').addEventListener('click', async () => {
    let data = await putSocio();
    mostrarSocio(data);
});
document.getElementById('delete').addEventListener('click', async () => {
    let data = await deleteSocio();
    mostrarSocio(data);
});


function mostrarSocio(data) {
    document.getElementById('mostrar').innerHTML = `
        <p>${data.id}</p>
        <p>${data.nombre}</p>
        <p>${data.apellido}</p>
        <p>${data.telefono}</p> `;
}

function mostrarSocios(data){
    data.forEach(element => {
        document.getElementById('mostrar').innerHTML += `
        <p>${element.id}</p>
        <p>${element.nombre}</p>
        <p>${element.apellido}</p>
        <p>${element.telefono}</p> `;
    });
}