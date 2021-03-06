require_relative 'AzureReport/sdk_requirements'
include MyNamespace

describe 'AutoRestReportService' do
  before(:all) do
    dummyToken = 'dummy12321343423'
    dummySubscription = '1-1-1-1'
    @credentials = MsRestAzure::TokenCloudCredentials.new(dummySubscription, dummyToken)

    @base_url = ENV['StubServerURI']

    @client = AutoRestReportServiceForAzure.new(@credentials, @base_url)
  end

  it 'should send a report' do
    result = @client.get_report().value!.body
    count_of_methods = 0
    count_of_calls = 0
    result.each do |key, value|
      count_of_methods += 1
      if value.to_i > 0
        count_of_calls += 1
      end
    end

    puts "Test Coverage is #{count_of_calls}/#{count_of_methods}"
    expect(count_of_calls / count_of_methods.to_f > 0.4).to be_truthy
  end
end
