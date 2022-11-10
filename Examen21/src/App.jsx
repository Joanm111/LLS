import { useState,useEffect } from 'react'
import './App.css'
import DataTable from 'react-data-table-component'

const App = ()=> {
  const [autor, setAutor] = useState([])
  const URL = 'https://localhost:44350/api/Autor'
  const mostrar = async() => {
    const response = await fetch(URL)
    const data= await response.json()
    console.log(data)
    setAutor(data)
  }

  useEffect(() => {
    mostrar()
   
  }, [])
  
  const columns = [
    {
      name:'ID',
      selector: row =>  row.id_Autor
    },
    {
      name:'nombre',
      selector: row =>  row.nombre
    },
    {
      name:'apellido',
      selector: row =>  row.apellido
    },
    {
      name:'nacionalidad',
      selector: row =>  row.nacionalidad
    }
  ]

  return (
    <div className="App">
      <h1>Tabla de Autor</h1>
      <DataTable
      columns={columns}
      data={autor}
      />
    </div>
  )
}

export default App