import httpClient from "../infra/http-client";
import { Injectable } from "@angular/core";
import { query } from "express";

@Injectable({
  providedIn: "root",
})
export class GetsService {
  constructor() {}

  public matchAutocomplete = async (type: string, quesy: string) => {
    const resp = await httpClient.get(
      `/api/AutoComplete/get_match?fileName=${type}&query=${query}`
    );

    console.log(resp.data);
  };
}
