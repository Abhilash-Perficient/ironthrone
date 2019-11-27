<configuration xmlns:patch="http://www.sitecore.net/xmlconfig/" xmlns:role="http://www.sitecore.net/xmlconfig/role/">
  <sitecore role:require="Standalone or ContentManagement">
    <sc.variable name="sourceFolder" value="~\App_Data\unicorn" /> 
    <unicorn>
      <configurations>
        <configuration name="Helix.Base" abstract="true">
          <predicate type="Unicorn.Predicates.SerializationPresetPredicate, Unicorn" singleInstance="true" />

          <targetDataStore physicalRootPath="$(sourceFolder)\MainSerialization\$(layer).$(module)\serialization" useDataCache="false" singleInstance="true" />
          <!--<dataStore physicalRootPath="$(configDirectory)\$(layer)\$(module)\serialization\$(configurationName)" />-->


        </configuration>
        
        <!-- Foundation modules -->
        <configuration name="Helix.Foundation" abstract="true" extends="Helix.Base">
          <predicate>
            <include name="Templates" database="master" path="/sitecore/templates/$(layer)/$(module)" />
          </predicate>
        </configuration>

        <!-- Feature modules -->
        <configuration name="Helix.Feature" abstract="true" extends="Helix.Base">
          <predicate>
            <include name="Templates" database="master" path="/sitecore/templates/$(layer)/$(module)" />
            <include name="Renderings" database="master" path="/sitecore/layout/renderings/$(layer)/$(module)" />
            <!--<include name="Media" database="master" path="/sitecore/media library/$(layer)/$(module)" />-->
            <include name="Placeholder Settings" database="master" path="/sitecore/layout/Placeholder Settings/$(layer)/$(module)" />
            <include name="Branch Templates" database="master" path="/sitecore/templates/Branches/$(layer)/$(module)" />
            <include name="Health Settings" database="master" path="/sitecore/system/Settings/Feature/$(layer)/$(module)" />            
          </predicate>
        </configuration>

        <!-- Project modules -->
        <configuration name="Helix.Project" abstract="true" extends="Helix.Base">
          <predicate>
            <include name="Templates" database="master" path="/sitecore/templates/$(layer)/$(module)" />
            <include name="Renderings" database="master" path="/sitecore/layout/renderings/$(layer)/$(module)" />
            <include name="Placeholder Settings" database="master" path="/sitecore/layout/Placeholder Settings/$(layer)/$(module)" />
            <include name="Branch Templates" database="master" path="/sitecore/templates/Branches/$(layer)/$(module)" />
          </predicate>
        </configuration>
        <syncConfiguration type="Unicorn.Loader.DefaultSyncConfiguration, Unicorn" singleInstance="true" updateLinkDatabase="true" updateSearchIndex="true" maxConcurrency="1" />
      </configurations>
    </unicorn>
  </sitecore>
</configuration>
