import { Injectable } from '@angular/core';
import { TeamName } from 'src/app/models/team.name';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class OfferFactoryService {

  constructor() { }

  getUrl(teamName: TeamName) : string | null {
      switch (teamName) {
        case TeamName.MiNIPackage:
          return environment.MiniPackage.url;
        case TeamName.Szymon:
        case TeamName.Maciek:
        case TeamName.NONE:
          return null;
      }
  }
}
