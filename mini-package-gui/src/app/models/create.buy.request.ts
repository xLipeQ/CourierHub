import { TeamName } from "./team.name";

export class CreateBuyOfferRequest {
  userId: number = 0;
  inquireId: number = 0;
  inquirGuid: string = "";
  teamName: TeamName = TeamName.NONE;

  constructor() {

  }
}
