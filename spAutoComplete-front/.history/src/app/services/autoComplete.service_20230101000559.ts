import httpClient from "../infra/http-client";
import { Injectable } from "@angular/core";

@Injectable({
  providedIn: "root",
})
class AutoCompleteService {
  public matchPartial = async (type: string, query: string) => {
    const resp = await httpClient.get(
      `/api/AutoComplete/get_match?fileName=${type}&query=${query}`
    );

    return resp.data;
  };
}
