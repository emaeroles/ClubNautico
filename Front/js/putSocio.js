function dataPutSocio() {
    let id = document.getElementById('id').value;
    let nombre = document.getElementById('nombre').value;
    let apellido = document.getElementById('apellido').value;
    let telefono = document.getElementById('telefono').value;
    let socio = { 'id': id, 'nombre': nombre, 'apellido': apellido, 'telefono': telefono };
    return socio;
}

async function putSocio() {
    let socio = dataPutSocio();
    let url = 'https://localhost:7013/api/Socio/update';
    try {
        let response = await fetch(url, {
            method: 'put',
            headers: {'Content-Type': 'application/json'},
            body: JSON.stringify(socio)
        });
        if(response.ok){
            let data = await response.json();
            return data;
        }
    } catch (e) {
        console.log(e);
    }
}