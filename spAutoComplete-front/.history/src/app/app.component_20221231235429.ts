import { Component } from "@angular/core";
import {GetsService} from "./services/gets.service";

@Component({
  selector: "app-root",
  templateUrl: "./app.component.html",
  styleUrls: ["./app.component.css"],
})
export class AppComponent {
  searchForAutoComplete = async (type: string, event: any) => {
    return GetsService.
    return "searchForAutoComplete";
  };
}
