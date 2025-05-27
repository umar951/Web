import axios from "axios"
export  const api = axios.create({
    baseURL: 'http://localhost:5100',
    timeout: 4000,
})