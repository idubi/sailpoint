import httpClient from "../infra/http-client";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";

import { query } from "express";

@Injectable({
  providedIn: "root",
})
export class PostsService {
  constructor(private http: HttpClient) {}

  matchAutocomplete = async (type: string, quesy: string) => {
    const resp = await httpClient.get(
      `/api/AutoComplete/get_match?fileName=${type}&query=${query}`
    );

    console.log(resp.data);
  };
}
