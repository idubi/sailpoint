import httpClient from "../infra/http-client";
import { Injectable } from "@angular/core";

@Injectable({
  providedIn: "root",
})
export class AutoCompleteService {
  public async matchPartial(type: string, query: string) {
    const resp = httpClient.get(
      `/api/AutoComplete/get_match?fileName=${type}&query=${query}`
    );

    return resp;
  }
}
