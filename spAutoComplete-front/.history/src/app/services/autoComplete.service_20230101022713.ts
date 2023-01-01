import httpClient from "../infra/http-client";
import { Injectable } from "@angular/core";

@Injectable({
  providedIn: "root",
})
export class AutoCompleteService {
  public async matchPartial(type: string, query: string) {
    const resp = await httpClient.get(
      `https://localhost:7152/api/AutoComplete/get_match?fileName=${type}&query=${query}`,
      {
        headers: {
          "Access-Control-Allow-Origin": "http://localhost:4200",
          "Access-Control-Allow-Credentials": "true",
        },
      }
    );
    return resp;
  }
}
