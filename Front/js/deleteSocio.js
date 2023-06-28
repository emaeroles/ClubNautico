function dataDeleteSocio(){
    let id = document.getElementById('id').value;
    return id;
}

async function deleteSocio(id) {
    let id = dataDeleteSocio();
    let url = 'https://localhost:7013/api/Socio/delete/' + id;
    try {
        let response = await fetch(url, {
            method: "delete"
        });
        if(response.ok){
            let data = await response.json();
            return data;
        }
    } catch (e) {
        console.log(e);
    }
}