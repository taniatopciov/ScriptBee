import { Component, Input } from '@angular/core';
import { MarketplaceBundlePlugin } from "../../../services/plugin/marketplace-plugin";

@Component({
  selector: 'app-expanded-bundle-row',
  templateUrl: './expanded-bundle-row.component.html',
  styleUrls: ['./expanded-bundle-row.component.scss']
})
export class ExpandedBundleRowComponent {

  @Input() bundle: MarketplaceBundlePlugin;

  constructor() {
  }

  getPluginVersions() {
    return Object.entries(this.bundle.versions);
  }

  installBundle(version: string) {

  }

  uninstallBundle(version: string) {

  }
}
