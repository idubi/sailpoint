import { Component } from "@angular/core";
import { GetsService } from "./services/gets.service.js";

@Component({
  selector: "app-root",
  templateUrl: "./app.component.html",
  styleUrls: ["./app.component.css"],
})
export class AppComponent {
  public searchForAutoComplete = async (type: string, event: any) => {
    console.log();
    return searchForAutoComplete;
  };
}
