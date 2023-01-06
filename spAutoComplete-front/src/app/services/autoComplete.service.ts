import { httpClient, ENDPOINTS } from "../infra/http-client";
import { Injectable } from "@angular/core";

@Injectable({
  providedIn: "root",
})
export class AutoCompleteService {
  public async matchPartial(type: string, query: string) {
    const resp = await httpClient.get(
      `${ENDPOINTS.autoComplete}?fileName=${type}&query=${query}`
    );
    return resp;
  }
}
