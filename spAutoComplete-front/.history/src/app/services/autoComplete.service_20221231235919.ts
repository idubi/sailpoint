import httpClient from "../infra/http-client";
import { Injectable } from "@angular/core";

@Injectable({
  providedIn: "root",
})
export class autocompleteService {
  public matchAutocomplete = async (type: string, query: string) => {
    const resp = await httpClient.get(
      `/api/AutoComplete/get_match?fileName=${type}&query=${query}`
    );

    console.log(resp.data);
  };
}
