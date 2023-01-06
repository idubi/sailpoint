import axios from "axios";
const AXIOS_CONFIG = {
  baseURL: "https://localhost:7152",
  headers: {
    accept: "application/json",
    "Content-Type": "application/x-www-form-urlencoded",
  },
};

const ENDPOINTS = {
  autoComplete: "api/AutoComplete/get_match",
};

const httpClient = axios.create(AXIOS_CONFIG);

export { httpClient, ENDPOINTS };
