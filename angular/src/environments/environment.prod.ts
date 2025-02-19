import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44343/',
  redirectUri: baseUrl,
  clientId: 'AbpSolution1_App',
  responseType: 'code',
  scope: 'offline_access AbpSolution1',
  requireHttps: true,
};

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'AbpSolution1',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44343',
      rootNamespace: 'AbpSolution1',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
  remoteEnv: {
    url: '/getEnvConfig',
    mergeStrategy: 'deepmerge'
  }
} as Environment;
